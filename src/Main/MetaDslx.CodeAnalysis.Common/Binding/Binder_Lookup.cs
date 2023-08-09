using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public partial class Binder
    {
        public LookupContext AllocateLookupContext(
            string? name = null,
            string? metadataName = null,
            DeclaredSymbol? qualifier = null,
            LookupContext? qualifierContext = null,
            TypeSymbol? accessThroughType = null,
            bool diagnose = false,
            bool inImport = false,
            bool isLookup = false,
            IEnumerable<ILookupValidator> validators = default)
        {
            var context = Compilation[Language].SemanticsFactory.LookupContextPool.Allocate();
            context.OriginalBinder = this;
            context.Location = this.Location;
            context.Validators.UnionWith(validators);
            context.SetName(name, metadataName);
            context.SetQualifier(qualifier, qualifierContext);
            context.AccessThroughType = accessThroughType;
            context.Diagnose = diagnose;
            context.InImport = inImport;
            context.IsLookup = isLookup;
            return context;
        }

    }
}
