using Autofac;
using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.Symbols.Errors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    public struct LanguageScope
    {
        private readonly Compilation _compilation;
        private readonly Language _language;
        private readonly ILifetimeScope _serviceScope;
        private SemanticsFactory _semanticsFactory;
        private DefaultLookupValidator _defaultLookupValidator;
        private ErrorSymbolFactory _errorSymbolFactory;

        public LanguageScope(Compilation compilation, Language language, ILifetimeScope serviceScope)
        {
            _compilation = compilation;
            _language = language;
            _serviceScope = serviceScope;
        }

        public Compilation Compilation => _compilation;
        public Language Language => _language;
        public ILifetimeScope ServiceScope => _serviceScope;

        public SemanticsFactory SemanticsFactory
        {
            get
            {
                if (_semanticsFactory is null)
                {
                    Interlocked.CompareExchange(ref _semanticsFactory, _serviceScope.Resolve<SemanticsFactory>(), null);
                }
                return _semanticsFactory;
            }
        }

        public DefaultLookupValidator DefaultLookupValidator
        {
            get
            {
                if (_defaultLookupValidator is null)
                {
                    Interlocked.CompareExchange(ref _defaultLookupValidator, SemanticsFactory.CreateDefaultLookupValidator(), null);
                }
                return _defaultLookupValidator;
            }
        }

        public ErrorSymbolFactory ErrorSymbolFactory
        {
            get
            {
                if (_errorSymbolFactory is null)
                {
                    Interlocked.CompareExchange(ref _errorSymbolFactory, _language.CompilationFactory.CreateErrorSymbolFactory(_compilation), null);
                }
                return _errorSymbolFactory;
            }
        }
    }
}
