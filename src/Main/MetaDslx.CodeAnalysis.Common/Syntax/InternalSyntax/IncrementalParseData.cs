using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public sealed class IncrementalParseData
    {
        public static readonly IncrementalParseData Empty = new IncrementalParseData(0, null, null, DirectiveStack.Empty, 0, 0, null);

        private int _version;
        private SyntaxNode _rootNode;
        private LexerStateManager? _lexerStateManager;
        private ParserStateManager? _parserStateManager;
        private DirectiveStack _directives;
        private int _lexerLookAhead;
        private int _lexerLookBack;
        private ConditionalWeakTable<GreenNode, IncrementalNodeData>? _incrementalData;

        internal IncrementalParseData(int version, LexerStateManager? lexerStateManager, ParserStateManager? parserStateManager, DirectiveStack directives, int lexerLookAhead, int lexerLookBack, ConditionalWeakTable<GreenNode, IncrementalNodeData>? incrementalData)
        {
            _version = version;
            _rootNode = null;
            _lexerStateManager = lexerStateManager;
            _parserStateManager = parserStateManager;
            _directives = directives;
            _lexerLookAhead = lexerLookAhead;
            _lexerLookBack = lexerLookBack;
            _incrementalData = incrementalData;
        }

        internal IncrementalParseData(IncrementalParseData old)
        {
            _version = old._version + 1;
            _rootNode = null;
            _lexerStateManager = old._lexerStateManager;
            _parserStateManager = old._parserStateManager;
            _directives = old._directives;
            _lexerLookAhead = old._lexerLookAhead;
            _lexerLookBack = old._lexerLookBack;
            _incrementalData = old._incrementalData;
        }

        public bool IsIncremental => _version > 0;

        public int Version => _version;

        public SyntaxNode RootNode { get => _rootNode; internal set => _rootNode = value; }

        public DirectiveStack Directives => _directives;

        public int LexerLookAhead { get => _lexerLookAhead; internal set => _lexerLookAhead = value; }

        public int LexerLookBack { get => _lexerLookBack; internal set => _lexerLookBack = value; }

        public LexerStateManager? LexerStateManager => _lexerStateManager;

        public ParserStateManager? ParserStateManager => _parserStateManager;

        internal ConditionalWeakTable<GreenNode, IncrementalNodeData>? IncrementalData => _incrementalData;

        public IncrementalParseData WithDirectives(DirectiveStack directives)
        {
            return new IncrementalParseData(this.Version, _lexerStateManager, _parserStateManager, directives, _lexerLookAhead, _lexerLookBack, _incrementalData);
        }

        public bool TryGetIncrementalData(GreenNode green, out IncrementalNodeData? data)
        {
            if (_incrementalData == null)
            {
                data = null;
                return false;
            }
            return _incrementalData.TryGetValue(green, out data);
        }

    }
}
