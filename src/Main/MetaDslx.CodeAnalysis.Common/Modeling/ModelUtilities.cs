using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling
{
    public static class ModelUtilities
    {
        public static T? GetInnermostContainingObject<T>(this IModelObject? mobj, bool includeSelf = false, CancellationToken cancellationToken = default)
            where T : IModelObject
        {
            if (mobj is null) return default;
            var container = includeSelf ? mobj : mobj.MParent;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is T ts) return ts;
                container = container.MParent;
            }
            return default;
        }

        public static T? GetOutermostContainingObject<T>(this IModelObject? mobj, bool includeSelf = false, CancellationToken cancellationToken = default)
            where T : IModelObject
        {
            if (mobj is null) return default;
            T? result = default;
            var container = includeSelf ? mobj : mobj.MParent;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is T ts) result = ts;
                container = container.MParent;
            }
            return result;
        }

        public static ImmutableArray<T> GetAllContainingObjectsInwards<T>(this IModelObject? mobj, bool includeSelf = false, CancellationToken cancellationToken = default)
            where T : IModelObject
        {
            if (mobj is null) return ImmutableArray<T>.Empty;
            var result = ArrayBuilder<T>.GetInstance();
            var container = includeSelf ? mobj : mobj.MParent;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is T ts) result.Add(ts);
                container = container.MParent;
            }
            result.ReverseContents();
            return result.ToImmutableAndFree();
        }

        public static ImmutableArray<T> GetAllContainingObjectsOutwards<T>(this IModelObject? mobj, bool includeSelf = false, CancellationToken cancellationToken = default)
            where T : IModelObject
        {
            if (mobj is null) return ImmutableArray<T>.Empty;
            var result = ArrayBuilder<T>.GetInstance();
            var container = includeSelf ? mobj : mobj.MParent;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is T ts) result.Add(ts);
                container = container.MParent;
            }
            return result.ToImmutableAndFree();
        }

        public static ImmutableArray<T> GetAllContainedObjects<T>(this IModelObject? mobj, bool includeSelf = false, CancellationToken cancellationToken = default)
            where T : IModelObject
        {
            if (mobj is null) return ImmutableArray<T>.Empty;
            var result = ArrayBuilder<T>.GetInstance();
            var queue = ArrayBuilder<IModelObject>.GetInstance();
            queue.Add(mobj);
            int i = 0;
            while (i < queue.Count)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var current = queue[i];
                if (current is T ts)
                {
                    if (includeSelf && i == 0 || i > 0) result.Add(ts);
                }
                if (current is IModelObject cmobj)
                {
                    queue.AddRange(cmobj.MChildren);
                }
                ++i;
            }
            queue.Free();
            return result.ToImmutableAndFree();
        }


    }
}
