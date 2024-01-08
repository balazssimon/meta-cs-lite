using MetaDslx.Bootstrap.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Generators
{
    public partial class RoslynApiGenerator
    {
        private readonly Language _language;

        public RoslynApiGenerator(Language language)
        {
            _language = language;
        }

        public string Namespace => _language.Namespace;
        public string Lang => _language.Name;

        public Language Language => _language;
        public Grammar Grammar => _language.Grammar;
        public Rule? MainRule => Grammar.MainRule;

        public IList<Token> Tokens => Grammar.Tokens;
        public IList<Rule> Rules => Grammar.Rules;
        public IList<Token> FixedTokens => Grammar.Tokens.Where(t => t.IsFixed).ToList();
        public IList<Token> NonFixedTokens => Grammar.Tokens.Where(t => !t.IsFixed).ToList();
    }
}
