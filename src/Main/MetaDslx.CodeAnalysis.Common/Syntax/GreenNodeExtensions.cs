// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using MetaDslx.CodeAnalysis.PooledObjects;

namespace MetaDslx.CodeAnalysis
{
    public static class GreenNodeExtensions
    {
        public static TNode WithAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation> annotations) where TNode : GreenNode
        {
            if (node == null) return null;
            var newAnnotations = ArrayBuilder<SyntaxAnnotation>.GetInstance();
            foreach (var candidate in annotations)
            {
                if (!newAnnotations.Contains(candidate))
                {
                    newAnnotations.Add(candidate);
                }
            }

            if (newAnnotations.Count == 0)
            {
                newAnnotations.Free();
                var existingAnnotations = node.GetAnnotations();
                if (existingAnnotations == null || existingAnnotations.Length == 0)
                {
                    return node;
                }
                else
                {
                    return (TNode)node.SetAnnotations(null);
                }
            }
            else
            {
                return (TNode)node.SetAnnotations(newAnnotations.ToArrayAndFree());
            }
        }

        public static TNode WithAdditionalAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation>? annotations) where TNode : GreenNode
        {
            var existingAnnotations = node.GetAnnotations();

            if (annotations == null)
            {
                return node;
            }

            var newAnnotations = ArrayBuilder<SyntaxAnnotation>.GetInstance();
            newAnnotations.AddRange(existingAnnotations);

            foreach (var candidate in annotations)
            {
                if (!newAnnotations.Contains(candidate))
                {
                    newAnnotations.Add(candidate);
                }
            }

            if (newAnnotations.Count == existingAnnotations.Length)
            {
                newAnnotations.Free();
                return node;
            }
            else
            {
                return (TNode)node.SetAnnotations(newAnnotations.ToArrayAndFree());
            }
        }

        public static TNode WithoutAnnotationsGreen<TNode>(this TNode node, IEnumerable<SyntaxAnnotation>? annotations) where TNode : GreenNode
        {
            var existingAnnotations = node.GetAnnotations();

            if (annotations == null || existingAnnotations.Length == 0)
            {
                return node;
            }

            var removalAnnotations = ArrayBuilder<SyntaxAnnotation>.GetInstance();
            removalAnnotations.AddRange(annotations);
            try
            {
                if (removalAnnotations.Count == 0)
                {
                    return node;
                }

                var newAnnotations = ArrayBuilder<SyntaxAnnotation>.GetInstance();
                foreach (var candidate in existingAnnotations)
                {
                    if (!removalAnnotations.Contains(candidate))
                    {
                        newAnnotations.Add(candidate);
                    }
                }

                return (TNode)node.SetAnnotations(newAnnotations.ToArrayAndFree());
            }
            finally
            {
                removalAnnotations.Free();
            }
        }

        public static TNode WithDiagnosticsGreen<TNode>(this TNode node, IEnumerable<DiagnosticInfo> diagnostics) where TNode : GreenNode
        {
            var newDiagnostics = ArrayBuilder<DiagnosticInfo>.GetInstance();
            foreach (var candidate in diagnostics)
            {
                if (!newDiagnostics.Contains(candidate))
                {
                    newDiagnostics.Add(candidate);
                }
            }

            if (newDiagnostics.Count == 0)
            {
                newDiagnostics.Free();
                var existingDiagnostics = node.GetDiagnostics();
                if (existingDiagnostics == null || existingDiagnostics.Length == 0)
                {
                    return node;
                }
                else
                {
                    return (TNode)node.SetDiagnostics(null);
                }
            }
            else
            {
                return (TNode)node.SetDiagnostics(newDiagnostics.ToArrayAndFree());
            }
        }

        public static TNode WithAdditionalDiagnosticsGreen<TNode>(this TNode node, IEnumerable<DiagnosticInfo>? diagnostics) where TNode : GreenNode
        {
            var existingDiagnostics = node.GetDiagnostics();

            if (diagnostics == null)
            {
                return node;
            }

            var newDiagnostics = ArrayBuilder<DiagnosticInfo>.GetInstance();
            newDiagnostics.AddRange(existingDiagnostics);

            foreach (var candidate in diagnostics)
            {
                if (!newDiagnostics.Contains(candidate))
                {
                    newDiagnostics.Add(candidate);
                }
            }

            if (newDiagnostics.Count == existingDiagnostics.Length)
            {
                newDiagnostics.Free();
                return node;
            }
            else
            {
                return (TNode)node.SetDiagnostics(newDiagnostics.ToArrayAndFree());
            }
        }

        public static TNode WithoutDiagnosticsGreen<TNode>(this TNode node, IEnumerable<DiagnosticInfo>? diagnostics) where TNode : GreenNode
        {
            var existingDiagnostics = node.GetDiagnostics();

            if (diagnostics == null || existingDiagnostics.Length == 0)
            {
                return node;
            }

            var removalDiagnostics = ArrayBuilder<DiagnosticInfo>.GetInstance();
            removalDiagnostics.AddRange(diagnostics);
            try
            {
                if (removalDiagnostics.Count == 0)
                {
                    return node;
                }

                var newDiagnostics = ArrayBuilder<DiagnosticInfo>.GetInstance();
                foreach (var candidate in existingDiagnostics)
                {
                    if (!removalDiagnostics.Contains(candidate))
                    {
                        newDiagnostics.Add(candidate);
                    }
                }

                return (TNode)node.SetDiagnostics(newDiagnostics.ToArrayAndFree());
            }
            finally
            {
                removalDiagnostics.Free();
            }
        }

        public static TNode WithDiagnosticsGreen<TNode>(this TNode node, DiagnosticInfo[]? diagnostics) where TNode : GreenNode
        {
            return (TNode)node.SetDiagnostics(diagnostics);
        }

        public static TNode WithoutDiagnosticsGreen<TNode>(this TNode node) where TNode : GreenNode
        {
            var current = node.GetDiagnostics();
            if (current == null || current.Length == 0)
            {
                return node;
            }

            return (TNode)node.SetDiagnostics(null);
        }
    }
}
