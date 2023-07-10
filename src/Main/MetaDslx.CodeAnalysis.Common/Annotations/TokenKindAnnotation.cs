using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Annotations
{
    public class TokenKindAnnotation : Annotation
    {
        private TokenKind _kind;
        private bool _isDefault;

        public TokenKindAnnotation(TokenKind kind, bool isDefault = false)
        {
            _kind = kind;
            _isDefault = isDefault;
        }

        public TokenKind Kind => _kind;
        public bool IsDefault => _isDefault;
    }
}
