using Antlr4.Runtime;
using MetaDslx.Bootstrap.MetaCompiler.Roslyn;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    using Model = MetaDslx.Modeling.Model;

    public class CompilerToRoslyn
    {
        private readonly Model _cmodel;
        private readonly Model _rmodel;
        private readonly RoslynModelFactory f;
        private readonly Language? _clang;
        private Roslyn.Language _rlang;
        private HashSet<string> _ruleNames;
        private Dictionary<string, Token> _fixedTokens;

        public CompilerToRoslyn(Model compilerModel)
        {
            _cmodel = compilerModel;
            _rmodel = new Model();
            f = new RoslynModelFactory(_rmodel);
            _clang = _cmodel.Objects.OfType<Language>().FirstOrDefault();
        }

        public Model Convert()
        {
            if (_clang is null) return _rmodel;
            if (_rlang is not null) return _rmodel;
            _ruleNames = new HashSet<string>();
            _fixedTokens = new Dictionary<string, Token>();

            var cfixedTokens = _cmodel.Objects.OfType<LexerRule>().Where(lr => !lr.IsFragment && lr.IsFixed);
            var cnonFixedTokens = _cmodel.Objects.OfType<LexerRule>().Where(lr => !lr.IsFragment && !lr.IsFixed);
            var crules = _cmodel.Objects.OfType<ParserRule>();
            var cblocks = _cmodel.Objects.OfType<PBlock>();
            var cnamedBlocks = _cmodel.Objects.OfType<PBlock>().Where(blk => !string.IsNullOrEmpty(blk.Name));

            _rlang = f.Language();
            _rlang.Name = _clang.Name;
            _ruleNames = new HashSet<string>();
            _ruleNames.UnionWith(_cmodel.Objects.OfType<LexerRule>().Where(lr => !string.IsNullOrEmpty(lr.Name)).Select(lr => lr.Name!));
            AddTokens(cfixedTokens, false);
            AddTokensFromRules(crules);
            AddTokensFromRules(cblocks);
            AddTokens(cnonFixedTokens, false);

            MakeBlockNames(crules);
            MakeBlockNames(cnamedBlocks);

            AddRules(crules);
            AddBlocks(cblocks);
            return _rmodel;
        }

        private void AddTokens(IEnumerable<LexerRule> ctokens, bool checkNames)
        {
            foreach (var ctoken in ctokens)
            {
                AddToken(ctoken, checkNames);
            }
        }

        private void AddToken(string fixedText)
        {
            if (_fixedTokens.ContainsKey(fixedText)) return;
            var rtoken = f.Token();
            _rlang.Tokens.Add(rtoken);
            rtoken.Name = MakeFixedTokenName(fixedText);
            rtoken.IsTrivia = false;
            rtoken.IsFixed = true;
            rtoken.FixedText = fixedText;
            _fixedTokens.Add(fixedText, rtoken);
        }

        private void AddToken(LexerRule ctoken, bool checkNames)
        {
            if (ctoken.IsFixed && _fixedTokens.ContainsKey(ctoken.FixedText)) return;
            var rtoken = f.Token();
            _rlang.Tokens.Add(rtoken);
            var name = ctoken.Name;
            if (string.IsNullOrEmpty(name) || checkNames && _ruleNames.Contains(name))
            {
                if (ctoken.IsFixed) name = MakeFixedTokenName(ctoken.FixedText);
                else name = MakeTokenName();
            }
            rtoken.Name = name;
            if (rtoken.IsFixed) _fixedTokens.Add(rtoken.FixedText, rtoken);
            rtoken.IsTrivia = ctoken.IsHidden;
            rtoken.IsFixed = ctoken.IsFixed;
            rtoken.FixedText = ctoken.FixedText;
            var rtokenKindSymbol = ctoken.Annotations.Where(a => a.AttributeClass?.Name?.EndsWith("TokenKind") ?? false).FirstOrDefault()?.AttributeClass;
            if (rtokenKindSymbol is not null)
            {
                var kind = _rlang.TokenKinds.FirstOrDefault(tk => tk.Name == rtokenKindSymbol.Name);
                if (kind is null)
                {
                    kind = f.TokenKind();
                    kind.Name = rtokenKindSymbol.Name;
                    kind.TypeName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(rtokenKindSymbol);
                    _rlang.TokenKinds.Add(kind);
                }
                rtoken.TokenKind = kind;
            }
            AddBinders(rtoken.Binders, ctoken.Annotations);
        }

        private void AddBinders(IList<Binder> rbinders, IList<Annotation> cannotations)
        {
            foreach (var cbinder in cannotations.Where(a => a.AttributeClass?.Name?.EndsWith("Binder") ?? false))
            {
                var rbinder = f.Binder();
                rbinders.Add(rbinder);
                rbinder.TypeName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(cbinder.AttributeClass);
                foreach (var carg in cbinder.Arguments)
                {
                    var rarg = f.BinderArgument();
                    rarg.Name = carg.Parameter?.Name;
                    rarg.Values.Add(carg.Value?.Value.ToString());
                    rbinder.Arguments.Add(rarg);
                }
            }
        }

        private string MakeTokenName()
        {
            var result = "TToken";
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{result}{index}";
                if (!_ruleNames.Contains(name))
                {
                    _ruleNames.Add(name);
                    return name;
                }
            }
        }

        private string MakeFixedTokenName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return MakeTokenName();
            var keyword = PooledStringBuilder.GetInstance();
            var keywordBuilder = keyword.Builder;
            var other = PooledStringBuilder.GetInstance();
            var otherBuilder = other.Builder;
            var isKeyword = true;
            var first = true;
            keywordBuilder.Append('K');
            otherBuilder.Append('T');
            foreach (var ch in value)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || !first && ch >= '0' && ch <= '9')
                {
                    keywordBuilder.Append(first ? char.ToUpper(ch) : ch);
                    otherBuilder.Append(first ? char.ToUpper(ch) : ch);
                }
                else
                {
                    isKeyword = false;
                    var otherName = GetOtherCharacterName(ch);
                    if (otherName is not null) otherBuilder.Append(otherName);
                    else otherBuilder.Append('_');
                }
                first = false;
            }
            var result = other.ToStringAndFree();
            if (isKeyword) result = keyword.ToStringAndFree();
            else keyword.Free();
            if (result.Length == 1) return MakeTokenName();
            if (_ruleNames.Contains(result))
            {
                var index = 0;
                while (true)
                {
                    ++index;
                    var name = $"{result}{index}";
                    if (!_ruleNames.Contains(name))
                    {
                        _ruleNames.Add(name);
                        return name;
                    }
                }
            }
            _ruleNames.Add(result);
            return result;
        }

        private static string? GetOtherCharacterName(char ch)
        {
            switch (ch)
            {
                case '!': return "Excl";
                case '"': return "Quote";
                case '#': return "Hash";
                case '$': return "Dollar";
                case '%': return "Percent";
                case '&': return "Amp";
                case '\'': return "Apos";
                case '(': return "LParen";
                case ')': return "RParen";
                case '*': return "Asterisk";
                case '+': return "Plus";
                case ',': return "Comma";
                case '-': return "Minus";
                case '.': return "Dot";
                case '/': return "Slash";
                case ':': return "Colon";
                case ';': return "Semicolon";
                case '<': return "Lt";
                case '=': return "Eq";
                case '>': return "Gt";
                case '?': return "Question";
                case '@': return "At";
                case '[': return "LBracket";
                case '\\': return "Backslash";
                case ']': return "RBracket";
                case '^': return "Hat";
                case '_': return "Underscore";
                case '`': return "Accent";
                case '{': return "LBrace";
                case '|': return "Bar";
                case '}': return "RBrace";
                case '~': return "Tilde";
                default: return null;
            }
        }

        private void AddRules(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                var rrule = f.Rule();
                _rlang.Rules.Add(rrule);
                rrule.Name = crule.Name;
                AddBinders(rrule.Binders, crule.Annotations);
            }
        }

        private void AddBlocks(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                var rrule = f.Rule();
                _rlang.Rules.Add(rrule);
                rrule.Name = cblock.Name ?? string.Empty;
                AddBinders(rrule.Binders, cblock.Annotations);
            }
        }

        private void AddTokensFromRules(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                foreach (var alt in crule.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value is PKeyword ckeyword)
                        {
                            AddToken(ckeyword.Text);
                        }
                    }
                }
            }
        }

        private void AddTokensFromRules(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                foreach (var alt in cblock.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value is PKeyword ckeyword)
                        {
                            AddToken(ckeyword.Text);
                        }
                    }
                }
            }
        }

        private void MakeBlockNames(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                MakeBlockNames(crule.Name, crule.Alternatives);
            }
        }

        private void MakeBlockNames(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                MakeBlockNames(cblock.Name, cblock.Alternatives);
            }
        }

        private void MakeBlockNames(string parentName, IEnumerable<PAlternative> calts)
        {
            foreach (var calt in calts)
            {
                foreach (var elem in calt.Elements)
                {
                    if (elem.Value is PBlock cblock)
                    {
                        if (string.IsNullOrEmpty(cblock.Name))
                        {
                            cblock.Name = MakeBlockName(parentName, elem.SymbolProperty.FirstOrDefault().Name);
                            MakeBlockNames(cblock.Name, cblock.Alternatives);
                        }
                    }
                }
            }
        }

        private string MakeBlockName(string? parentName, string? elementName)
        {
            var result = (parentName.ToPascalCase() ?? string.Empty) + (elementName.ToPascalCase() ?? "Block");
            if (string.IsNullOrEmpty(result)) result = "Block";
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{result}{index}";
                if (!_ruleNames.Contains(name))
                {
                    _ruleNames.Add(name);
                    return name;
                }
            }
        }
    }
}
