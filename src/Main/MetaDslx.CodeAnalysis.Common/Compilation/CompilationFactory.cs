﻿using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Modeling;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public class CompilationFactory
    {
        public virtual Compilation CreateCompilation(
            string? assemblyName,
            Language? mainLanguage,
            CompilationOptions options,
            ImmutableArray<MetadataReference> references,
            ScriptCompilationInfo? scriptCompilationInfo,
            ReferenceManager? referenceManager,
            bool reuseReferenceManager,
            SyntaxAndDeclarationManager syntaxAndDeclarations)
        {
            return new Compilation(assemblyName, mainLanguage, options, references, scriptCompilationInfo,
                    referenceManager, reuseReferenceManager, syntaxAndDeclarations);
        }

        public virtual ReferenceManager CreateReferenceManager(Compilation compilation)
        {
            return new ReferenceManager();
        }

        public virtual AccessCheck CreateAccessCheck(Compilation compilation)
        {
            return new AccessCheck();
        }

        public virtual IMultiModelFactory CreateModelFactory(Compilation compilation)
        {
            var metaModels = ArrayBuilder<IMetaModel>.GetInstance();
            foreach (var reference in compilation.ExternalReferences.OfType<MetaModelReference>())
            {
                metaModels.Add(reference.MetaModel);
            }
            return new MultiModelFactory(metaModels.ToImmutableAndFree());
        }

        public virtual IModelGroup CreateModelGroup(Compilation compilation)
        {
            return new ModelGroup();
        }

        public virtual IModel CreateModel(Compilation compilation)
        {
            return new Model();
        }
    }
}
