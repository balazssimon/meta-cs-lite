using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public class AntlrLexerState : LexerState
    {
        public AntlrLexerState(int hashCode, bool hitEof, int mode, int[]? modeStackReversed)
            : base(hashCode)
        {
            this.HitEof = hitEof;
            this.Mode = mode;
            this.ModeStackReversed = modeStackReversed;
        }

        public bool HitEof { get; set; }
        public int Mode { get; }
        public int[]? ModeStackReversed { get; }

        public override string ToString()
        {
            string modeStack = string.Empty;
            if (ModeStackReversed != null && ModeStackReversed.Length > 0)
            {
                var builder = PooledStringBuilder.GetInstance();
                StringBuilder sb = builder.Builder;
                for (int i = ModeStackReversed.Length - 1; i >= 0; i--)
                {
                    if (i < ModeStackReversed.Length - 1) sb.Append(",");
                    sb.Append(ModeStackReversed[i]);
                }
                modeStack = builder.ToStringAndFree();
            }
            return $"mode={Mode}, modeStack={modeStack}, hitEof={HitEof}";
        }
    }
}
