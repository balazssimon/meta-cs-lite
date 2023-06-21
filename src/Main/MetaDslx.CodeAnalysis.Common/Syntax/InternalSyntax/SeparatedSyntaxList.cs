// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public struct SeparatedSyntaxList<TNode> : IEquatable<SeparatedSyntaxList<TNode>> where TNode : GreenNode
    {
        private readonly SyntaxList<GreenNode> _list;
        private readonly bool _reversed;

        public SeparatedSyntaxList(SyntaxList<GreenNode> list, bool reversed)
        {
            Validate(list, reversed);
            _list = list;
            _reversed = reversed;
        }

        [Conditional("DEBUG")]
        private static void Validate(SyntaxList<GreenNode> list, bool reversed)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var item = list.GetRequiredItem(i);
                if (reversed)
                {
                    if ((i & 1) == 0)
                    {
                        Debug.Assert(item.IsToken, "even elements of a separated list must be tokens");
                    }
                    else
                    {
                        Debug.Assert(!item.IsToken, "odd elements of a separated list must be nodes");
                    }
                }
                else
                {
                    if ((i & 1) == 0)
                    {
                        Debug.Assert(!item.IsToken, "even elements of a separated list must be nodes");
                    }
                    else
                    {
                        Debug.Assert(item.IsToken, "odd elements of a separated list must be tokens");
                    }
                }
            }
        }

        public bool IsReversed => _reversed;

        public GreenNode? Node => _list.Node;

        public int Count
        {
            get
            {
                return (_list.Count + (_reversed ? 0 : 1)) >> 1;
            }
        }

        public int SeparatorCount
        {
            get
            {
                return (_list.Count + (_reversed ? 1 : 0)) >> 1;
            }
        }

        public TNode? this[int index]
        {
            get
            {
                return (TNode?)_list[(index << 1) + (_reversed ? 1 : 0)];
            }
        }

        /// <summary>
        /// Gets the separator at the given index in this list.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public GreenNode? GetSeparator(int index)
        {
            return _list[(index << 1) + (_reversed ? 0 : 1)];
        }

        public SyntaxList<GreenNode> GetWithSeparators()
        {
            return _list;
        }

        public static bool operator ==(in SeparatedSyntaxList<TNode> left, in SeparatedSyntaxList<TNode> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(in SeparatedSyntaxList<TNode> left, in SeparatedSyntaxList<TNode> right)
        {
            return !left.Equals(right);
        }

        public bool Equals(SeparatedSyntaxList<TNode> other)
        {
            return _list == other._list;
        }

        public override bool Equals(object? obj)
        {
            return (obj is SeparatedSyntaxList<TNode>) && Equals((SeparatedSyntaxList<TNode>)obj);
        }

        public override int GetHashCode()
        {
            return _list.GetHashCode();
        }

        public static implicit operator SeparatedSyntaxList<GreenNode>(SeparatedSyntaxList<TNode> list)
        {
            return new SeparatedSyntaxList<GreenNode>(list.GetWithSeparators(), list._reversed);
        }

#if DEBUG
        [Obsolete("For debugging only", true)]
        private TNode[] Nodes
        {
            get
            {
                int count = this.Count;
                TNode[] array = new TNode[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = this[i]!;
                }
                return array;
            }
        }
#endif
    }
}
