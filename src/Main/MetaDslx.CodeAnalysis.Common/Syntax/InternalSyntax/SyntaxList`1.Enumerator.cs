﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public partial struct SyntaxList<TNode> where TNode : GreenNode
    {
        public struct Enumerator
        {
            private readonly SyntaxList<TNode> _list;
            private int _index;

            internal Enumerator(SyntaxList<TNode> list)
            {
                _list = list;
                _index = -1;
            }

            public bool MoveNext()
            {
                var newIndex = _index + 1;
                if (newIndex < _list.Count)
                {
                    _index = newIndex;
                    return true;
                }

                return false;
            }

            public TNode Current
            {
                get
                {
                    return _list[_index]!;
                }
            }
        }
    }
}
