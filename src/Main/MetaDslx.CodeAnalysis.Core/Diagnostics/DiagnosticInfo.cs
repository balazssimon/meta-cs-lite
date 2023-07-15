// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Roslyn.Utilities;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// A DiagnosticInfo object has information about a diagnostic, but without any attached location information.
    /// </summary>
    /// <remarks>
    /// More specialized diagnostics with additional information (e.g., ambiguity errors) can derive from this class to
    /// provide access to additional information about the error, such as what symbols were involved in the ambiguity.
    /// </remarks>
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public class DiagnosticInfo : IFormattable
    {
        private readonly DiagnosticDescriptor _descriptor;
        private readonly DiagnosticSeverity _effectiveSeverity;
        private readonly object[] _arguments;

        private static ImmutableDictionary<int, DiagnosticDescriptor> s_errorCodeToDescriptorMap = ImmutableDictionary<int, DiagnosticDescriptor>.Empty;

        // Mark compiler errors as non-configurable to ensure they can never be suppressed or filtered.
        private static readonly ImmutableArray<string> s_compilerErrorCustomTags = ImmutableArray.Create(WellKnownDiagnosticTags.Compiler, WellKnownDiagnosticTags.Telemetry, WellKnownDiagnosticTags.NotConfigurable);
        private static readonly ImmutableArray<string> s_compilerNonErrorCustomTags = ImmutableArray.Create(WellKnownDiagnosticTags.Compiler, WellKnownDiagnosticTags.Telemetry);

        // Only the compiler creates instances.
        internal DiagnosticInfo(DiagnosticDescriptor descriptor)
        {
            _descriptor = descriptor;
            _effectiveSeverity = descriptor.DefaultSeverity;
            _arguments = Array.Empty<object>();
        }

        // Only the compiler creates instances.
        internal DiagnosticInfo(DiagnosticDescriptor descriptor, params object[] arguments)
            : this(descriptor)
        {
            _arguments = arguments;
        }

        protected DiagnosticInfo(DiagnosticInfo original, DiagnosticSeverity overriddenSeverity)
        {
            _descriptor = original.Descriptor;
            _arguments = original._arguments;

            _effectiveSeverity = overriddenSeverity;
        }

        // Only the compiler creates instances.
        internal DiagnosticInfo(DiagnosticDescriptor descriptor, bool isWarningAsError, params object[] arguments)
            : this(descriptor, arguments)
        {
            Debug.Assert(!isWarningAsError || _descriptor.DefaultSeverity == DiagnosticSeverity.Warning);

            if (isWarningAsError)
            {
                _effectiveSeverity = DiagnosticSeverity.Error;
            }
        }

        // Create a copy of this instance with a explicit overridden severity
        internal virtual DiagnosticInfo GetInstanceWithSeverity(DiagnosticSeverity severity)
        {
            return new DiagnosticInfo(this, severity);
        }

        /// <summary>
        /// Returns the effective severity of the diagnostic: whether this diagnostic is informational, warning, or error.
        /// If IsWarningsAsError is true, then this returns <see cref="DiagnosticSeverity.Error"/>, while <see cref="DefaultSeverity"/> returns <see cref="DiagnosticSeverity.Warning"/>.
        /// </summary>
        public DiagnosticSeverity Severity
        {
            get
            {
                return _effectiveSeverity;
            }
        }

        /// <summary>
        /// Returns whether this diagnostic is informational, warning, or error by default, based on the error code.
        /// To get diagnostic's effective severity, use <see cref="Severity"/>.
        /// </summary>
        public DiagnosticSeverity DefaultSeverity
        {
            get
            {
                return _descriptor.DefaultSeverity;
            }
        }

        /// <summary>
        /// Gets the warning level. This is 0 for diagnostics with severity <see cref="DiagnosticSeverity.Error"/>,
        /// otherwise an integer greater than zero.
        /// </summary>
        public int WarningLevel
        {
            get
            {
                if (_effectiveSeverity != _descriptor.DefaultSeverity)
                {
                    return Diagnostic.GetDefaultWarningLevel(_effectiveSeverity);
                }

                return Diagnostic.GetDefaultWarningLevel(_descriptor.DefaultSeverity);
            }
        }

        /// <summary>
        /// Returns true if this is a warning treated as an error.
        /// </summary>
        /// <remarks>
        /// True implies <see cref="Severity"/> = <see cref="DiagnosticSeverity.Error"/> and
        /// <see cref="DefaultSeverity"/> = <see cref="DiagnosticSeverity.Warning"/>.
        /// </remarks>
        public bool IsWarningAsError
        {
            get
            {
                return this.DefaultSeverity == DiagnosticSeverity.Warning &&
                    this.Severity == DiagnosticSeverity.Error;
            }
        }

        /// <summary>
        /// Get the diagnostic category for the given diagnostic code.
        /// Default category is <see cref="Diagnostic.CompilerDiagnosticCategory"/>.
        /// </summary>
        public string Category
        {
            get
            {
                return _descriptor.Category;
            }
        }

        internal ImmutableArray<string> CustomTags
        {
            get
            {
                return _descriptor.CustomTags;
            }
        }

        private static ImmutableArray<string> GetCustomTags(DiagnosticSeverity defaultSeverity)
        {
            return defaultSeverity == DiagnosticSeverity.Error ?
                s_compilerErrorCustomTags :
                s_compilerNonErrorCustomTags;
        }

        internal bool IsNotConfigurable()
        {
            // Only compiler errors are non-configurable.
            return _descriptor.DefaultSeverity == DiagnosticSeverity.Error;
        }

        /// <summary>
        /// If a derived class has additional information about other referenced symbols, it can
        /// expose the locations of those symbols in a general way, so they can be reported along
        /// with the error.
        /// </summary>
        public virtual IReadOnlyList<Location> AdditionalLocations
        {
            get
            {
                return SpecializedCollections.EmptyReadOnlyList<Location>();
            }
        }

        /// <summary>
        /// Get the message id (for example "CS1001") for the message. This includes both the error number
        /// and a prefix identifying the source.
        /// </summary>
        public virtual string MessageIdentifier
        {
            get
            {
                return _descriptor.Id;
            }
        }

        /// <summary>
        /// Get the text of the message in the given language.
        /// </summary>
        public virtual string GetMessage(IFormatProvider? formatProvider = null)
        {
            // Get the message and fill in arguments.
            string message = _descriptor.MessageFormat;
            if (string.IsNullOrEmpty(message))
            {
                return string.Empty;
            }

            if (_arguments.Length == 0)
            {
                return message;
            }

            return String.Format(formatProvider, message, GetArgumentsToUse(formatProvider));
        }

        protected object[] GetArgumentsToUse(IFormatProvider? formatProvider)
        {
            object[]? argumentsToUse = null;
            for (int i = 0; i < _arguments.Length; i++)
            {
                var embedded = _arguments[i] as DiagnosticInfo;
                if (embedded != null)
                {
                    argumentsToUse = InitializeArgumentListIfNeeded(argumentsToUse);
                    argumentsToUse[i] = embedded.GetMessage(formatProvider);
                    continue;
                }

                var arg = _arguments[i];
                if (arg != null)
                {
                    argumentsToUse = InitializeArgumentListIfNeeded(argumentsToUse);
                    argumentsToUse[i] = arg.ToString();
                }
            }

            return argumentsToUse ?? _arguments;
        }

        private object[] InitializeArgumentListIfNeeded(object[]? argumentsToUse)
        {
            if (argumentsToUse != null)
            {
                return argumentsToUse;
            }

            var newArguments = new object[_arguments.Length];
            Array.Copy(_arguments, newArguments, newArguments.Length);

            return newArguments;
        }

        internal object[] Arguments
        {
            get { return _arguments; }
        }

        public DiagnosticDescriptor Descriptor
        {
            get { return _descriptor; }
        }

        // TODO (tomat): remove
        public override string? ToString()
        {
            return ToString(null);
        }

        public string ToString(IFormatProvider? formatProvider)
        {
            return ((IFormattable)this).ToString(null, formatProvider);
        }

        string IFormattable.ToString(string? format, IFormatProvider? formatProvider)
        {
            return String.Format(formatProvider, "{0}: {1}", _descriptor.Id, this.GetMessage(formatProvider));
        }

        public sealed override int GetHashCode()
        {
            int hashCode = _descriptor.GetHashCode();
            for (int i = 0; i < _arguments.Length; i++)
            {
                hashCode = Hash.Combine(_arguments[i], hashCode);
            }

            return hashCode;
        }

        public sealed override bool Equals(object? obj)
        {
            DiagnosticInfo? other = obj as DiagnosticInfo;

            bool result = false;

            if (other != null &&
                other._descriptor == _descriptor &&
                other.GetType() == this.GetType())
            {
                if (_arguments.Length == other._arguments.Length)
                {
                    result = true;
                    for (int i = 0; i < _arguments.Length; i++)
                    {
                        if (!object.Equals(_arguments[i], other._arguments[i]))
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }

            return result;
        }

        private string? GetDebuggerDisplay()
        {
            if (_descriptor == InternalDiagnosticDescriptors.Unknown) return "Unresolved DiagnosticInfo";
            if (_descriptor == InternalDiagnosticDescriptors.Void) return "Void DiagnosticInfo";
            return ToString();
        }

        /// <summary>
        /// For a DiagnosticInfo that is lazily evaluated, this method evaluates it
        /// and returns a non-lazy DiagnosticInfo.
        /// </summary>
        internal virtual DiagnosticInfo GetResolvedInfo()
        {
            // We should never call GetResolvedInfo on a non-lazy DiagnosticInfo
            throw ExceptionUtilities.Unreachable;
        }
    }
}
