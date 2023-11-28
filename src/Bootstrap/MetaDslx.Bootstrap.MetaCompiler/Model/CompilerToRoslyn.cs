using MetaDslx.Bootstrap.MetaCompiler.Roslyn;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    using Model = MetaDslx.Modeling.Model;

    public class CompilerToRoslyn
    {
        public Model Convert(Model compilerModel)
        {
            var result = new Model();
            var f = new RoslynModelFactory(result);
            var clang = compilerModel.Objects.OfType<Language>().FirstOrDefault();
            if (clang is null) return result;
            var rlang = f.Language();
            rlang.Name = clang.Name;
            var ctokens = compilerModel.Objects.OfType<LexerRule>().Where(lr => !lr.IsFragment);
            foreach (var ctoken in ctokens)
            {
                var rtoken = f.Token();
                rlang.Tokens.Add(rtoken);
                rtoken.Name = ctoken.Name;
                rtoken.IsTrivia = ctoken.IsHidden;
                rtoken.IsFixed = ctoken.IsFixed;
                rtoken.FixedText = ctoken.FixedText;
                var rtokenKindSymbol = ctoken.Annotations.Where(a => a.AttributeClass?.Name?.EndsWith("TokenKind") ?? false).FirstOrDefault()?.AttributeClass;
                if (rtokenKindSymbol is not null)
                {
                    var kind = rlang.TokenKinds.FirstOrDefault(tk => tk.Name == rtokenKindSymbol.Name);
                    if (kind is null)
                    {
                        kind = f.TokenKind();
                        kind.Name = rtokenKindSymbol.Name;
                        kind.TypeName = SymbolDisplayFormat.FullyQualifiedFormat.ToString(rtokenKindSymbol);
                        rlang.TokenKinds.Add(kind);
                    }
                    rtoken.TokenKind = kind;
                }
                foreach (var cbinder in ctoken.Annotations.Where(a => a.AttributeClass?.Name?.EndsWith("Binder") ?? false))
                {
                    var rbinder = f.Binder();
                    rbinder.FullName = SymbolDisplayFormat.FullyQualifiedFormat.ToString(cbinder.AttributeClass);
                    foreach (var carg in cbinder.Arguments)
                    {
                        var rarg = f.BinderArgument();
                        //rarg.Name = carg.
                    }
                }
            }
            return result;
        }
    }
}
