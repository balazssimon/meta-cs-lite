using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public class CodeTemplateToken : InternalSyntaxToken
    {
        private CodeTemplateTokenKind _kind;
        private string _text;

        public CodeTemplateToken(CodeTemplateTokenKind kind, string text)
            : base((ushort)kind, text.Length)
        {
            _kind = kind;
            _text = text;
        }

        public override Language Language => Language.NoLanguage;

        public CodeTemplateTokenKind Kind => _kind;

        public override string KindText => _kind.ToString();

        public override string Text => _text;

        public override GreenNode Clone()
        {
            return new CodeTemplateToken(_kind, _text);
        }

        public override InternalSyntaxNode WithAnnotations(SyntaxAnnotation[]? annotations)
        {
            throw new NotImplementedException();
        }

        public override InternalSyntaxNode WithDiagnostics(DiagnosticInfo[]? diagnostics)
        {
            throw new NotImplementedException();
        }
    }
}
