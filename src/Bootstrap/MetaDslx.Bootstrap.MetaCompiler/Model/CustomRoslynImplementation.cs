using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.Bootstrap.MetaCompiler.Model;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;

namespace MetaDslx.Bootstrap.MetaCompiler.Roslyn
{
    internal class CustomRoslynImplementation : CustomRoslynImplementationBase
    {
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
            return $"{_this.Name}Green";
        }

        public override string Alternative_GreenUpdateArguments(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => $", {e.ParameterName}"));
        }

        public override string Alternative_GreenUpdateParameters(Alternative _this)
        {
            return string.Join(", ", _this.Elements.Select(e => $", {e.GreenPropertyType} {e.ParameterName}"));
        }

        public override string Alternative_RedName(Alternative _this)
        {
            return $"{_this.Name}Syntax";
        }

        public override string? ElementValue_GreenSyntaxCondition(ElementValue _this)
        {
            throw new NotImplementedException();
        }

        public override string ElementValue_GreenType(ElementValue _this)
        {
            throw new NotImplementedException();
        }

        public override string Element_FieldName(Element _this)
        {
            return $"_{_this.Name.ToCamelCase()}";
        }

        public override string Element_GreenFieldType(Element _this)
        {
            if (_this.Multiplicity.IsList()) return "GreenNode";
            else return _this.Value.GreenType;
        }

        public override string Element_GreenParameterValue(Element _this)
        {
            if (_this.Multiplicity.IsList()) return $"{_this.ParameterName}.Node";
            else if (_this.Value is SeparatedList) return $"{_this.ParameterName}.Node";
            else return _this.ParameterName;
        }

        public override string Element_GreenPropertyType(Element _this)
        {
            if (_this.Multiplicity.IsList()) return $"MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<{_this.Value.GreenType}>";
            else return _this.Value.GreenType;
        }

        public override string Element_GreenPropertyValue(Element _this)
        {
            if (_this.Multiplicity.IsList())
            {
                return $"new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SyntaxList<{_this.Value.GreenType}>({_this.FieldName})";
            }
            else if (_this.Value is SeparatedList sl)
            {
                return $"new MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<{_this.Value.GreenType}>({_this.FieldName}, reversed: {sl.SeparatorFirst.ToString().ToLower()})";
            }
            else
            {
                return _this.FieldName;
            }
        }

        public override string? Element_GreenSyntaxCondition(Element _this)
        {
            if (_this.Multiplicity.IsList()) return null;
            if (_this.Multiplicity.IsOptional() || _this.Value is SeparatedList) return _this.Value.GreenSyntaxCondition;
            else return $"{_this.ParameterName} is not null && ({_this.Value.GreenSyntaxCondition})";
        }

        public override string? Element_GreenSyntaxNullCondition(Element _this)
        {
            if (_this.Multiplicity.IsList()) return null;
            if (_this.Value is SeparatedList) return null;
            if (_this.Multiplicity.IsOptional()) return null;
            return $"{_this.ParameterName} is null";
        }

        public override string Element_ParameterName(Element _this)
        {
            return _this.Name.ToCamelCase().EscapeCSharpKeyword();
        }

        public override string Element_PropertyName(Element _this)
        {
            return _this.Name;
        }

        public override string? Eof_GreenSyntaxCondition(Eof _this)
        {
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            return $"{parameterName}.RawKind != (int)InternalSyntaxKind.Eof";
        }

        public override string Eof_GreenType(Eof _this)
        {
            return "InternalSyntaxToken";
        }

        public override string? RuleRef_GreenSyntaxCondition(RuleRef _this)
        {
            return null;
        }

        public override string RuleRef_GreenType(RuleRef _this)
        {
            return _this.Rule.GreenName;
        }

        public override string Rule_GreenName(Rule _this)
        {
            return $"{_this.Name}Green";
        }

        public override string? SeparatedList_GreenSyntaxCondition(SeparatedList _this)
        {
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            if (_this.SeparatorFirst) return $"!{parameterName}.IsReversed";
            else return $"{parameterName}.IsReversed";
        }

        public override string SeparatedList_GreenType(SeparatedList _this)
        {
            var itemType = ((RuleRef)_this.RepeatedItem.Value).Rule.GreenName;
            return $"MetaDslx.CodeAnalysis.Syntax.InternalSyntax.SeparatedSyntaxList<{itemType}>";
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
                sb.Append(tokenRef.Token.Name);
            }
            return builder.ToStringAndFree();
        }

        public override string TokenAlts_GreenType(TokenAlts _this)
        {
            return "InternalSyntaxToken";
        }

        public override string? TokenRef_GreenSyntaxCondition(TokenRef _this)
        {
            var languageName = _this.GetInnermostContainingObject<Language>()?.Name;
            var parameterName = _this.GetInnermostContainingObject<Element>()?.ParameterName;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(parameterName);
            sb.Append(".RawKind != (int)");
            sb.Append(languageName);
            sb.Append("SyntaxKind.");
            sb.Append(_this.Token.Name);
            return builder.ToStringAndFree();
        }

        public override string TokenRef_GreenType(TokenRef _this)
        {
            return "InternalSyntaxToken";
        }
    }
}
