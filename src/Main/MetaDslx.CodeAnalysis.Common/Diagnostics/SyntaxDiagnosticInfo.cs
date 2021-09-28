// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using System;
using System.Diagnostics;
using Roslyn.Utilities;

namespace MetaDslx.CodeAnalysis
{
    public class SyntaxDiagnosticInfo : DiagnosticInfo
    {
        public readonly int Offset;
        public readonly int Width;

        internal SyntaxDiagnosticInfo(int offset, int width, DiagnosticDescriptor descriptor, params object[] args)
            : base(descriptor, args)
        {
            Debug.Assert(width >= 0);
            this.Offset = offset;
            this.Width = width;
        }

        internal SyntaxDiagnosticInfo(int offset, int width, DiagnosticDescriptor descriptor)
            : this(offset, width, descriptor, Array.Empty<object>())
        {
        }

        internal SyntaxDiagnosticInfo(DiagnosticDescriptor descriptor, params object[] args)
            : this(0, 0, descriptor, args)
        {
        }

        internal SyntaxDiagnosticInfo(DiagnosticDescriptor descriptor)
            : this(0, 0, descriptor)
        {
        }

        public SyntaxDiagnosticInfo WithOffset(int offset)
        {
            return new SyntaxDiagnosticInfo(offset, this.Width, this.Descriptor, this.Arguments);
        }

    }
}
