// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Reflection.PortableExecutable;
using MetaDslx.Modeling;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Represents metadata image reference.
    /// </summary>
    /// <remarks>
    /// Represents a logical location of the image, not the content of the image. 
    /// The content might change in time. A snapshot is taken when the compiler queries the reference for its metadata.
    /// </remarks>
    public abstract class MetadataReference
    {
        public MetadataReferenceProperties Properties { get; }

        protected MetadataReference(MetadataReferenceProperties properties)
        {
            this.Properties = properties;
        }

        /// <summary>
        /// Path or name used in error messages to identity the reference.
        /// </summary>
        public virtual string? Display { get { return null; } }

        /// <summary>
        /// Returns true if this reference is an unresolved reference.
        /// </summary>
        internal virtual bool IsUnresolved
        {
            get { return false; }
        }

        /// <summary>
        /// Returns an instance of the reference with specified aliases.
        /// </summary>
        /// <param name="aliases">The new aliases for the reference.</param>
        /// <exception cref="ArgumentException">Alias is invalid for the metadata kind.</exception> 
        public MetadataReference WithAliases(IEnumerable<string> aliases)
        {
            return WithAliases(ImmutableArray.CreateRange(aliases));
        }

        /// <summary>
        /// Returns an instance of the reference with specified aliases.
        /// </summary>
        /// <param name="aliases">The new aliases for the reference.</param>
        /// <exception cref="ArgumentException">Alias is invalid for the metadata kind.</exception> 
        public MetadataReference WithAliases(ImmutableArray<string> aliases)
        {
            return WithProperties(Properties.WithAliases(aliases));
        }

        /// <summary>
        /// Returns an instance of the reference with specified properties, or this instance if properties haven't changed.
        /// </summary>
        /// <param name="properties">The new properties for the reference.</param>
        /// <exception cref="ArgumentException">Specified values not valid for this reference.</exception>
        public MetadataReference WithProperties(MetadataReferenceProperties properties)
        {
            if (properties == this.Properties)
            {
                return this;
            }

            return WithPropertiesCore(properties);
        }

        protected abstract MetadataReference WithPropertiesCore(MetadataReferenceProperties properties);

        /// <summary>
        /// Creates a reference to an assembly or standalone module stored in a file.
        /// Reads the content of the file into memory.
        /// </summary>
        /// <param name="path">Path to the assembly file.</param>
        /// <exception cref="ArgumentNullException"><paramref name="path"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="path"/> is invalid.</exception>
        /// <exception cref="IOException">An error occurred while reading the file.</exception>
        public static MetadataReference CreateFromFile(string path)
        {
            return new CSharpMetadataReference(Microsoft.CodeAnalysis.MetadataReference.CreateFromFile(path, default, null));
        }

        /// <summary>
        /// Creates a reference to a meta-model, from which the compiler creates model instances.
        /// </summary>
        /// <param name="metaModel">The meta-model instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="metaModel"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="metaModel"/> is invalid.</exception>
        public static MetadataReference CreateFromMetaModel(MetaModel metaModel)
        {
            if (metaModel is null) throw new ArgumentNullException(nameof(metaModel));
            return new MetaModelReference(metaModel, default);
        }

        /// <summary>
        /// Creates a reference to a model.
        /// </summary>
        /// <param name="model">The model instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="model"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="model"/> is invalid.</exception>
        public static MetadataReference CreateFromModel(MetaDslx.Modeling.Model model)
        {
            if (model is null) throw new ArgumentNullException(nameof(model));
            return new ModelReference(model, default);
        }

        /// <summary>
        /// Creates a reference to another compilation.
        /// </summary>
        /// <param name="compilation">The referenced compilation.</param>
        /// <exception cref="ArgumentNullException"><paramref name="compilation"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="compilation"/> is invalid.</exception>
        public static MetadataReference CreateFromCompilation(Compilation compilation)
        {
            if (compilation is null) throw new ArgumentNullException(nameof(compilation));
            return new CompilationReference(compilation, default);
        }

        /// <summary>
        /// Creates a reference from an original Roslyn metadata reference.
        /// </summary>
        /// <param name="reference">The Roslyn metadata reference.</param>
        /// <exception cref="ArgumentNullException"><paramref name="reference"/> is null.</exception>
        /// <exception cref="ArgumentException"><paramref name="reference"/> is invalid.</exception>
        public static MetadataReference CreateFromMicrosoft(Microsoft.CodeAnalysis.MetadataReference reference)
        {
            if (reference is null) throw new ArgumentNullException(nameof(reference));
            return new CSharpMetadataReference(reference);
        }
    }
}
