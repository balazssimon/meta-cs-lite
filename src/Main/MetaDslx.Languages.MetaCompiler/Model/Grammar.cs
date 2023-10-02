using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public class GrammarOptions
    {
        public bool IsCaseInsensitive { get; set; }
        public bool IsWhitespaceIndented { get; set; }
    }

    public class Grammar : NamedElement
    {
        private readonly Language _language;
        private ImmutableArray<LexerRule> _fixedLexerRules;
        private ImmutableArray<LexerRule> _nonFixedLexerRules;
        private ImmutableArray<LexerRule> _lexerRules;
        private ImmutableArray<ParserRule> _parserRules;

        public Grammar(Language language)
        {
            _language = language;
        }

        public Language Language => _language;

        public GrammarOptions Options { get; set; }
        public List<Rule> Rules { get; } = new List<Rule>();

        public LexerRule? DefaultWhitespace { get; set; }
        public LexerRule? DefaultEndOfLine { get; set; }
        public LexerRule? DefaultSeparator { get; set; }
        public LexerRule? DefaultIdentifier { get; set; }
        public ParserRule? MainRule { get; set; }
        public Microsoft.CodeAnalysis.INamedTypeSymbol? RootType { get; set; }

        public ImmutableArray<LexerRule> FixedLexerRules
        {
            get
            {
                if (_fixedLexerRules == null) _fixedLexerRules = Rules.OfType<LexerRule>().Where(lr => lr.IsFixed).ToImmutableArray();
                return _fixedLexerRules;
            }
        }
        public ImmutableArray<LexerRule> NonFixedLexerRules
        {
            get
            {
                if (_nonFixedLexerRules == null) _nonFixedLexerRules = Rules.OfType<LexerRule>().Where(lr => !lr.IsFixed).ToImmutableArray();
                return _nonFixedLexerRules;
            }
        }
        public ImmutableArray<LexerRule> LexerRules
        {
            get
            {
                if (_lexerRules == null)
                {
                    var lexerRules = ArrayBuilder<LexerRule>.GetInstance();
                    lexerRules.AddRange(FixedLexerRules);
                    lexerRules.AddRange(NonFixedLexerRules);
                    _lexerRules = lexerRules.ToImmutableAndFree();
                }
                return _lexerRules;
            }
        }
        public ImmutableArray<ParserRule> ParserRules
        {
            get
            {
                if (_parserRules == null) _parserRules = Rules.OfType<ParserRule>().ToImmutableArray();
                return _parserRules;
            }
        }

    }

}
