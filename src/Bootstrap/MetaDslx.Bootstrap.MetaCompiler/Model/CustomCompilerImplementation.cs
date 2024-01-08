using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    internal class CustomCompilerImplementation : CustomCompilerImplementationBase
    {
        public override string Declaration_FullName(Declaration _this)
        {
            if (_this.MParent is Declaration parent && !string.IsNullOrEmpty(parent.Name)) return $"{parent.FullName}.{_this.Name}";
            else return _this.Name;
        }

        public override string? LAlternative_FixedText(LAlternative _this)
        {
            return _this.IsFixed ? string.Concat(_this.Elements.Select(e => e.FixedText)) : null;
        }

        public override bool LAlternative_IsFixed(LAlternative _this)
        {
            return _this.Elements.All(e => e.IsFixed);
        }

        public override string? LBlock_FixedText(LBlock _this)
        {
            return _this.IsFixed ? _this.Alternatives[0].FixedText : null;
        }

        public override bool LBlock_IsFixed(LBlock _this)
        {
            return _this.Alternatives.Count == 1 && _this.Alternatives[0].IsFixed;
        }

        public override string? LElement_FixedText(LElement _this)
        {
            return _this?.Value.FixedText;
        }

        public override bool LElement_IsFixed(LElement _this)
        {
            return _this?.Value.IsFixed ?? false;
        }

        public override string? LElementValue_FixedText(LElementValue _this)
        {
            return null;
        }

        public override bool LElementValue_IsFixed(LElementValue _this)
        {
            return false;
        }

        public override string? LFixed_FixedText(LFixed _this)
        {
            return _this.Text;
        }

        public override bool LFixed_IsFixed(LFixed _this)
        {
            return true;
        }

        public override string? LRange_FixedText(LRange _this)
        {
            return _this.IsFixed ? _this.StartChar : null;
        }

        public override bool LRange_IsFixed(LRange _this)
        {
            return _this.StartChar == _this.EndChar;
        }

        public override string? LReference_FixedText(LReference _this)
        {
            return _this.Rule?.FixedText;
        }

        public override bool LReference_IsFixed(LReference _this)
        {
            return _this.Rule?.IsFixed ?? false;
        }

        public override string? LSet_FixedText(LSet _this)
        {
            return _this.IsFixed ? _this.Items[0].FixedText : null;
        }

        public override bool LSet_IsFixed(LSet _this)
        {
            return _this.Items.Count == 1 && _this.Items[0].IsFixed;
        }

        public override string LSetChar_FixedText(LSetChar _this)
        {
            return _this.Char;
        }

        public override bool LSetChar_IsFixed(LSetChar _this)
        {
            return true;
        }

        public override string? LSetItem_FixedText(LSetItem _this)
        {
            return null;
        }

        public override bool LSetItem_IsFixed(LSetItem _this)
        {
            return false;
        }

        public override string? LSetRange_FixedText(LSetRange _this)
        {
            return _this.IsFixed ? _this.StartChar : null;
        }

        public override bool LSetRange_IsFixed(LSetRange _this)
        {
            return _this.StartChar == _this.EndChar;
        }

        public override string? LWildCard_FixedText(LWildCard _this)
        {
            return null;
        }

        public override bool LWildCard_IsFixed(LWildCard _this)
        {
            return false;
        }

        public override string? LexerRule_FixedText(LexerRule _this)
        {
            return _this.IsFixed ? _this.Alternatives[0].FixedText : null;
        }

        public override bool LexerRule_IsFixed(LexerRule _this)
        {
            return _this.Alternatives.Count == 1 && _this.Alternatives[0].IsFixed;
        }

        public override string Alternative_GreenConstructorArguments(Alternative _this)
        {
            return string.Concat(_this.Elements.Select(e => $", {e.FieldName}"));
        }

        public override string Alternative_GreenConstructorParameters(Alternative _this)
        {
            return string.Concat(_this.Elements.Select(e => $", {e.GreenFieldType} {e.ParameterName}"));
        }

        public override string Alternative_GreenName(Alternative _this)
        {
            return $"{_this.CSharpName}Green";
        }

        public override string Alternative_GreenUpdateArguments(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => $"{e.ParameterName}"));
        }

        public override string Alternative_GreenUpdateParameters(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => $"{e.GreenPropertyType} {e.ParameterName}"));
        }

        public override bool Alternative_HasRedToGreenOptionalArguments(Alternative _this)
        {
            return _this.Elements.Any(e => e.IsOptionalUpdateParameter);
        }

        public override string Alternative_RedName(Alternative _this)
        {
            return $"{_this.CSharpName}Syntax";
        }

        public override string Alternative_RedOptionalUpdateParameters(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Where(e => !e.IsOptionalUpdateParameter).Select(e => $"{e.RedPropertyType} {e.ParameterName}"));
        }

        public override string Alternative_RedToGreenArgumentList(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => e.RedToGreenArgument));
        }

        public override string Alternative_RedToGreenOptionalArgumentList(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => e.RedToGreenOptionalArgument));
        }

        public override string Alternative_RedUpdateArguments(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => e.ParameterName));
        }

        public override string Alternative_RedUpdateParameters(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => $"{e.RedPropertyType} {e.ParameterName}"));
        }

        public override string Binder_ConstructorArguments(Binder _this)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var arg in _this.Arguments)
            {
                if (sb.Length > 0) sb.Append(", ");
                sb.Append(arg.Name);
                sb.Append(": ");
                if (arg.IsArray)
                {
                    sb.Append("ImmutableArray.Create<");
                    sb.Append(arg.TypeName);
                    sb.Append(">(");
                    bool first = true;
                    foreach (var value in arg.Values)
                    {
                        if (first) first = false;
                        else sb.Append(", ");
                        if (value != null && arg.TypeName == "System.String" && !value.StartsWith("\"")) sb.Append(value.EncodeString());
                        else if (value != null && arg.TypeName == "System.Type") sb.Append($"typeof({value})");
                        else sb.Append(value);
                    }
                    sb.Append(")");
                }
                else if (arg.Values.Count > 0)
                {
                    var value = arg.Values[0];
                    if (value != null && arg.TypeName == "System.String" && !value.StartsWith("\"")) sb.Append(value.EncodeString());
                    else if (value != null && arg.TypeName == "System.Type") sb.Append($"typeof({value})");
                    else sb.Append(value);
                }
            }
            return builder.ToStringAndFree();
        }

        public override string? ElementValue_GreenSyntaxCondition(ElementValue _this)
        {
            throw new NotImplementedException();
        }

        public override string ElementValue_GreenType(ElementValue _this)
        {
            throw new NotImplementedException();
        }

        public override string ElementValue_RedType(ElementValue _this)
        {
            throw new NotImplementedException();
        }

        public override string Element_FieldName(Element _this)
        {
            return $"_{_this.CSharpName.ToCamelCase()}";
        }

        public override string Element_GreenFieldType(Element _this)
        {
            if (_this.IsList) return "__GreenNode";
            else return _this.Value.GreenType;
        }

        public override string Element_GreenParameterValue(Element _this)
        {
            if (_this.IsList) return $"{_this.ParameterName}.Node";
            else return _this.ParameterName;
        }

        public override string Element_GreenPropertyType(Element _this)
        {
            if (_this.Multiplicity.IsList()) return $"global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<{_this.Value.GreenType}>";
            else if (_this.Value is SeparatedList) return $"global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<{_this.Value.GreenType}>";
            else return _this.Value.GreenType;
        }

        public override string Element_GreenPropertyValue(Element _this)
        {
            if (_this.Multiplicity.IsList())
            {
                return $"new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<{_this.Value.GreenType}>({_this.FieldName})";
            }
            else if (_this.Value is SeparatedList sl)
            {
                return $"new global::MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<{_this.Value.GreenType}>({_this.FieldName}, reversed: {sl.SeparatorFirst.ToString().ToLower()})";
            }
            else
            {
                return _this.FieldName;
            }
        }

        public override string? Element_GreenSyntaxCondition(Element _this)
        {
            if (_this.IsList) return null;
            var valueCondition = _this.Value.GreenSyntaxCondition;
            if (valueCondition is null) return null;
            if (_this.Multiplicity.IsOptional()) return valueCondition;
            else if (_this.IsToken) return $"{_this.ParameterName}.RawKind != (int)__InternalSyntaxKind.None && ({valueCondition})";
            else return $"{_this.ParameterName} is not null && ({valueCondition})";
        }

        public override string? Element_GreenSyntaxNullCondition(Element _this)
        {
            if (_this.IsList) return null;
            if (_this.Multiplicity.IsOptional()) return null;
            return $"{_this.ParameterName} is null";
        }

        public override bool Element_IsOptionalUpdateParameter(Element _this)
        {
            if (_this.Multiplicity.IsOptional()) return true;
            if (_this.Value is RuleRef tr && tr.Token is not null) return tr.Token.IsFixed;
            return false;
        }

        public override string Element_ParameterName(Element _this)
        {
            return _this.CSharpName.ToCamelCase().EscapeCSharpKeyword();
        }

        public override string Element_PropertyName(Element _this)
        {
            return _this.CSharpName;
        }

        public override string Element_RedFieldType(Element _this)
        {
            if (_this.Multiplicity.IsList()) return "__SyntaxNode";
            else if (_this.IsToken) return null;
            else return _this.Value.RedType;
        }

        public override string Element_RedParameterValue(Element _this)
        {
            if (_this.IsList) return $"{_this.ParameterName}.Node";
            else if (_this.IsToken) return $"{_this.ParameterName}.Node";
            else return _this.ParameterName;
        }

        public override string Element_RedPropertyType(Element _this)
        {
            if (_this.Multiplicity.IsList())
            {
                if (_this.IsToken) return "__SyntaxTokenList";
                else return $"global::MetaDslx.CodeAnalysis.SyntaxList<{_this.Value.RedType}>";
            }
            else if (_this.Value is SeparatedList) return $"global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<{_this.Value.RedType}>";
            else return _this.Value.RedType;
        }

        public override string Element_RedPropertyValue(Element _this)
        {
            if (_this.Multiplicity.IsList())
            {
                if (_this.IsToken) return $"new __SyntaxTokenList({_this.FieldName})";
                else return $"new global::MetaDslx.CodeAnalysis.SyntaxList<{_this.Value.GreenType}>({_this.FieldName})";
            }
            else if (_this.Value is SeparatedList sl)
            {
                return $"new global::MetaDslx.CodeAnalysis.SeparatedSyntaxList<{_this.Value.GreenType}>({_this.FieldName}, reversed: {sl.SeparatorFirst.ToString().ToLower()})";
            }
            else
            {
                return _this.FieldName;
            }
        }

        public override string? Element_RedSyntaxCondition(Element _this)
        {
            if (_this.IsList) return null;
            var valueCondition = _this.Value.GreenSyntaxCondition;
            if (valueCondition is null) return null;
            if (_this.Multiplicity.IsOptional()) return valueCondition;
            else if (_this.IsToken) return $"{_this.ParameterName}.RawKind != (int)__InternalSyntaxKind.None && ({valueCondition})";
            else return $"{_this.ParameterName} is not null && ({valueCondition})";
        }

        public override string? Element_RedSyntaxNullCondition(Element _this)
        {
            if (_this.IsList) return null;
            if (_this.Multiplicity.IsOptional()) return null;
            if (_this.IsToken) return $"{_this.ParameterName}.RawKind != (int)__InternalSyntaxKind.None";
            return $"{_this.ParameterName} is null";
        }

        public override string Element_RedToGreenArgument(Element _this)
        {
            if (_this.Multiplicity.IsList())
            {
                return $"__GreenNodeExtensions.ToGreenList<InternalSyntax.{_this.Value.GreenType}>({_this.ParameterName}.Node)";
            }
            else if (_this.Value is SeparatedList sl)
            {
                return $"__GreenNodeExtensions.ToGreenSeparatedList<InternalSyntax.{_this.Value.GreenType}>({_this.ParameterName}.Node, reversed: {sl.SeparatorFirst.ToString().ToLower()})";
            }
            else if (_this.IsToken)
            {
                return $"(__InternalSyntaxToken){_this.ParameterName}.Node";
            }
            else if (_this.Value is RuleRef rr && rr.Rule is not null)
            {
                return $"(InternalSyntax.{rr.Rule.GreenName}){_this.ParameterName}.Green";
            }
            else
            {
                return _this.RedParameterValue;
            }
        }

        public override string Element_RedToGreenOptionalArgument(Element _this)
        {
            var languageName = _this.GetInnermostContainingObject<Language>()?.Name;
            if (_this.Multiplicity.IsOptional()) return "default";
            else if (_this.Multiplicity.IsSingle() && _this.Value is Eof) return $"this.Token({languageName}SyntaxKind.Eof)";
            else if (_this.Multiplicity.IsSingle() && _this.Value is RuleRef rr && rr.Token is not null) return $"this.Token({languageName}SyntaxKind.{rr.Token.CSharpName})";
            else return _this.ParameterName;
        }

        public override string? Element_VisitCall(Element _this)
        {
            if (_this.IsList) return $"this.VisitList(node.{_this.PropertyName})";
            else if (_this.IsToken) return $"this.VisitToken(node.{_this.PropertyName})";
            else return $"({_this.RedPropertyType})this.Visit(node.{_this.PropertyName})";
        }

        public override string? Eof_GreenSyntaxCondition(Eof _this)
        {
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            return $"{parameterName}.RawKind != (int)__InternalSyntaxKind.Eof";
        }

        public override string Eof_GreenType(Eof _this)
        {
            return "__InternalSyntaxToken";
        }

        public override string Eof_RedType(Eof _this)
        {
            return "__SyntaxToken";
        }

        public override string? RuleRef_GreenSyntaxCondition(RuleRef _this)
        {
            if (_this.Token is not null)
            {
                var languageName = _this.GetInnermostContainingObject<Language>()?.Name;
                var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                sb.Append(parameterName);
                sb.Append(".RawKind != (int)");
                sb.Append(languageName);
                sb.Append("SyntaxKind.");
                sb.Append(_this.Token.CSharpName);
                return builder.ToStringAndFree();
            }
            return null;
        }

        public override string RuleRef_GreenType(RuleRef _this)
        {
            if (_this.Rule is not null) return _this.Rule.GreenName;
            else if (_this.Token is not null) return "__InternalSyntaxToken";
            else return null;
        }

        public override string RuleRef_RedType(RuleRef _this)
        {
            if (_this.Rule is not null) return _this.Rule.RedName;
            else if (_this.Token is not null) return "__SyntaxToken";
            else return null;
        }

        public override string Rule_GreenName(Rule _this)
        {
            return $"{_this.CSharpName}Green";
        }

        public override string Rule_RedName(Rule _this)
        {
            return $"{_this.CSharpName}Syntax";
        }

        public override string? SeparatedList_GreenSyntaxCondition(SeparatedList _this)
        {
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            if (_this.SeparatorFirst) return $"!{parameterName}.IsReversed";
            else return $"{parameterName}.IsReversed";
        }

        public override string SeparatedList_GreenType(SeparatedList _this)
        {
            return ((RuleRef)_this.RepeatedItem.Value).Rule.GreenName;
        }

        public override string SeparatedList_RedType(SeparatedList _this)
        {
            return ((RuleRef)_this.RepeatedItem.Value).Rule.RedName;
        }

        public override string? TokenAlts_GreenSyntaxCondition(TokenAlts _this)
        {
            var languageName = _this.GetInnermostContainingObject<Language>()?.Name;
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var tokenRef in _this.Tokens)
            {
                if (sb.Length > 0) sb.Append(" && ");
                sb.Append(parameterName);
                sb.Append(".RawKind != (int)");
                sb.Append(languageName);
                sb.Append("SyntaxKind.");
                sb.Append(tokenRef.Token.CSharpName);
            }
            return builder.ToStringAndFree();
        }

        public override string TokenAlts_GreenType(TokenAlts _this)
        {
            return "__InternalSyntaxToken";
        }

        public override string TokenAlts_RedType(TokenAlts _this)
        {
            return "__SyntaxToken";
        }

        public override Language GrammarRule_Language(GrammarRule _this)
        {
            return _this.Grammar?.Language;
        }

        public override string Language_Namespace(Language _this)
        {
            return _this.Parent?.FullName;
        }

        public override Token? RuleRef_Token(RuleRef _this)
        {
            return _this.GrammarRule as Token;
        }

        public override Rule? RuleRef_Rule(RuleRef _this)
        {
            return _this.GrammarRule as Rule;
        }

        public override bool Element_IsToken(Element _this)
        {
            return _this.Value is Eof || _this.Value is TokenAlts || _this.Value is RuleRef rr && rr.Token is not null;
        }

        public override bool Element_IsList(Element _this)
        {
            return _this.Multiplicity.IsList() || _this.Value is SeparatedList;
        }

    }

}
