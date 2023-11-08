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
            if (_this.Parent is null) return _this.Name;
            else return $"{_this.Parent.FullName}.{_this.Name}";
        }

        public override string LexerRuleAlternative_FixedText(LexerRuleAlternative _this)
        {
            return _this.IsFixed ? string.Concat(_this.Elements.Select(e => e.FixedText)) : null;
        }

        public override bool LexerRuleAlternative_IsFixed(LexerRuleAlternative _this)
        {
            return _this.Elements.All(e => e.IsFixed);
        }

        public override string LexerRuleBlockElement_FixedText(LexerRuleBlockElement _this)
        {
            return _this.IsFixed ? _this.Alternatives[0].FixedText : null;
        }

        public override bool LexerRuleBlockElement_IsFixed(LexerRuleBlockElement _this)
        {
            return _this.Alternatives.Count == 1 && _this.Alternatives[0].IsFixed;
        }

        public override string LexerRuleElement_FixedText(LexerRuleElement _this)
        {
            return null;
        }

        public override bool LexerRuleElement_IsFixed(LexerRuleElement _this)
        {
            return false;
        }

        public override string LexerRuleFixedStringElement_FixedText(LexerRuleFixedStringElement _this)
        {
            return _this.Text;
        }

        public override bool LexerRuleFixedStringElement_IsFixed(LexerRuleFixedStringElement _this)
        {
            return true;
        }

        public override string LexerRuleRangeElement_FixedText(LexerRuleRangeElement _this)
        {
            return _this.IsFixed ? _this.StartChar : null;
        }

        public override bool LexerRuleRangeElement_IsFixed(LexerRuleRangeElement _this)
        {
            return _this.StartChar == _this.EndChar;
        }

        public override string LexerRuleReferenceElement_FixedText(LexerRuleReferenceElement _this)
        {
            return _this.Rule?.FixedText;
        }

        public override bool LexerRuleReferenceElement_IsFixed(LexerRuleReferenceElement _this)
        {
            return _this.Rule?.IsFixed ?? false;
        }

        public override string LexerRuleSetElement_FixedText(LexerRuleSetElement _this)
        {
            return _this.IsFixed ? _this.Items[0].FixedText : null;
        }

        public override bool LexerRuleSetElement_IsFixed(LexerRuleSetElement _this)
        {
            return _this.Items.Count == 1 && _this.Items[0].IsFixed;
        }

        public override string LexerRuleSetFixedChar_FixedText(LexerRuleSetFixedChar _this)
        {
            return _this.Char;
        }

        public override bool LexerRuleSetFixedChar_IsFixed(LexerRuleSetFixedChar _this)
        {
            return true;
        }

        public override string LexerRuleSetItem_FixedText(LexerRuleSetItem _this)
        {
            return null;
        }

        public override bool LexerRuleSetItem_IsFixed(LexerRuleSetItem _this)
        {
            return false;
        }

        public override string LexerRuleSetRange_FixedText(LexerRuleSetRange _this)
        {
            return _this.IsFixed ? _this.StartChar : null;
        }

        public override bool LexerRuleSetRange_IsFixed(LexerRuleSetRange _this)
        {
            return _this.StartChar == _this.EndChar;
        }

        public override string LexerRuleWildCardElement_FixedText(LexerRuleWildCardElement _this)
        {
            return null;
        }

        public override bool LexerRuleWildCardElement_IsFixed(LexerRuleWildCardElement _this)
        {
            return false;
        }

        public override string LexerRule_FixedText(LexerRule _this)
        {
            return _this.IsFixed ? _this.Alternatives[0].FixedText : null;
        }

        public override bool LexerRule_IsFixed(LexerRule _this)
        {
            return _this.Alternatives.Count == 1 && _this.Alternatives[0].IsFixed;
        }

        public override Language Rule_Language(Rule _this)
        {
            return _this.Grammar.Language;
        }
    }
}
