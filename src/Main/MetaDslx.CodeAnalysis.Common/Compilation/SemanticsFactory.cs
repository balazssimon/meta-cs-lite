using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class SemanticsFactory
    {
        private Compilation _compilation;
        private Language _language;
        private ObjectPool<LookupContext> _lookupContextPool;

        public SemanticsFactory(Compilation compilation, Language language)
        {
            _compilation = compilation;
            _language = language;
            _lookupContextPool = new ObjectPool<LookupContext>(() => CreateLookupContext(_lookupContextPool), 128);
        }

        public Compilation Compilation => _compilation;
        public Language Language => _language;

        internal ObjectPool<LookupContext> LookupContextPool => _lookupContextPool;

        public abstract BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory);

        protected virtual LookupContext CreateLookupContext(ObjectPool<LookupContext> pool)
        {
            return new LookupContext(pool, _compilation, _language);
        }

        public virtual DefaultLookupValidator CreateDefaultLookupValidator()
        {
            return new DefaultLookupValidator(_compilation);
        }

    }
}
