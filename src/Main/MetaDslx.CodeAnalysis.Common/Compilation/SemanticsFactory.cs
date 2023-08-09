using MetaDslx.CodeAnalysis.Binding;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public abstract class SemanticsFactory
    {
        private Compilation _compilation;
        private ObjectPool<LookupContext> _lookupContextPool;

        public SemanticsFactory(Compilation compilation)
        {
            _compilation = compilation;
            _lookupContextPool = new ObjectPool<LookupContext>(() => CreateLookupContext(_lookupContextPool), 128);
        }

        public Compilation Compilation { get; }
        internal ObjectPool<LookupContext> LookupContextPool => _lookupContextPool;

        public abstract BinderFactoryVisitor CreateBinderFactoryVisitor(BinderFactory binderFactory);

        protected virtual LookupContext CreateLookupContext(ObjectPool<LookupContext> pool)
        {
            return new LookupContext(pool, _compilation);
        }

        public virtual DefaultLookupValidator CreateDefaultLookupValidator()
        {
            return new DefaultLookupValidator(_compilation);
        }

    }
}
