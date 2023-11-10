using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    internal class CustomCompilerImplementation : CustomCompilerImplementationBase
    {
        public override object? BoolExpression_Value(BoolExpression _this)
        {
            return _this.BoolValue;
        }

        public override string Declaration_FullName(Declaration _this)
        {
            if (_this.Parent is null) return _this.Name;
            else return $"{_this.Parent.FullName}.{_this.Name}";
        }

        public override object? Expression_Value(Expression _this)
        {
            return null;
        }

        public override object? IntExpression_Value(IntExpression _this)
        {
            return _this.IntValue;
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

        public override object? NullExpression_Value(NullExpression _this)
        {
            return null;
        }

        public override object? ReferenceExpression_Value(ReferenceExpression _this)
        {
            return _this.SymbolValue;
        }

        public override Language Rule_Language(Rule _this)
        {
            return _this.Grammar.Language;
        }

        public override object? StringExpression_Value(StringExpression _this)
        {
            return _this.StringValue;
        }
    }
}
