// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Diagnostics;

namespace MetaDslx.CodeAnalysis.Syntax
{
    internal struct SeparatedSyntaxListBuilder<TNode> where TNode : SyntaxNode
    {
        private readonly SyntaxListBuilder _builder;
        private readonly bool _reversed;
        private bool _expectedSeparator;

        public SeparatedSyntaxListBuilder(bool reversed, int size)
            : this(new SyntaxListBuilder(size), reversed)
        {
        }

        public static SeparatedSyntaxListBuilder<TNode> Create(bool reversed)
        {
            return new SeparatedSyntaxListBuilder<TNode>(reversed, 8);
        }

        internal SeparatedSyntaxListBuilder(SyntaxListBuilder builder, bool reversed)
        {
            _builder = builder;
            _reversed = reversed;
            _expectedSeparator = _reversed;
        }

        public bool IsNull
        {
            get
            {
                return _builder == null;
            }
        }

        public int Count
        {
            get
            {
                return _builder.Count;
            }
        }

        public void Clear()
        {
            _builder.Clear();
        }

        private void CheckExpectedElement()
        {
            if (_expectedSeparator)
            {
                throw new InvalidOperationException(ExceptionMessages.SeparatorIsExpected);
            }
        }

        private void CheckExpectedSeparator()
        {
            if (!_expectedSeparator)
            {
                throw new InvalidOperationException(ExceptionMessages.ElementIsExpected);
            }
        }

        public SeparatedSyntaxListBuilder<TNode> Add(TNode node)
        {
            CheckExpectedElement();
            _expectedSeparator = true;
            _builder.Add(node);
            return this;
        }

        public SeparatedSyntaxListBuilder<TNode> AddSeparator(in SyntaxToken separatorToken)
        {
            Debug.Assert(separatorToken.Node is object);
            CheckExpectedSeparator();
            _expectedSeparator = false;
            _builder.AddInternal(separatorToken.Node);
            return this;
        }

        public SeparatedSyntaxListBuilder<TNode> AddRange(in SeparatedSyntaxList<TNode> nodes)
        {
            CheckExpectedElement();
            SyntaxNodeOrTokenList list = nodes.GetWithSeparators();
            _builder.AddRange(list);
            _expectedSeparator = ((_builder.Count & 1) != (_reversed ? 1 : 0));
            return this;
        }

        public SeparatedSyntaxListBuilder<TNode> AddRange(in SeparatedSyntaxList<TNode> nodes, int count)
        {
            CheckExpectedElement();
            SyntaxNodeOrTokenList list = nodes.GetWithSeparators();
            _builder.AddRange(list, this.Count, Math.Min(count << 1, list.Count));
            _expectedSeparator = ((_builder.Count & 1) != (_reversed ? 1 : 0));
            return this;
        }

        public SeparatedSyntaxList<TNode> ToList()
        {
            if (_builder == null)
            {
                return new SeparatedSyntaxList<TNode>();
            }

            return _builder.ToSeparatedList<TNode>();
        }

        public SeparatedSyntaxList<TDerived> ToList<TDerived>() where TDerived : TNode
        {
            if (_builder == null)
            {
                return new SeparatedSyntaxList<TDerived>();
            }

            return _builder.ToSeparatedList<TDerived>();
        }

        public static implicit operator SyntaxListBuilder(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            return builder._builder;
        }

        public static implicit operator SeparatedSyntaxList<TNode>(in SeparatedSyntaxListBuilder<TNode> builder)
        {
            if (builder._builder != null)
            {
                return builder.ToList();
            }

            return default(SeparatedSyntaxList<TNode>);
        }
    }
}
