using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public static class StringUtils
    {
        public static string DecodeString(string text)
        {
            var sb = PooledStringBuilder.GetInstance();
            for (int i = 1; i < text.Length - 1; i++)
            {
                if (text[i] == '\\')
                {
                    ++i;
                    if (text[i] == 'u' || text[i] == 'U')
                    {
                        sb.Builder.Append(UnicodeChar(text.Substring(i + 1, 4)));
                        i += 5;
                    }
                    else
                    {
                        sb.Builder.Append(SpecialChar(text[i]));
                    }
                }
                else
                {
                    sb.Builder.Append(text[i]);
                }
            }
            return sb.ToStringAndFree();
        }

        public static char DecodeChar(string text)
        {
            if (text.Length >= 3)
            {
                if (text[1] == '\\')
                {
                    if (text[2] == 'u' || text[2] == 'U')
                    {
                        if (text.Length >= 7)
                        {
                            return UnicodeChar(text.Substring(3, 4));
                        }
                        else
                        {
                            return '\0';
                        }
                    }
                    else
                    {
                        return SpecialChar(text[2]);
                    }
                }
                else
                {
                    return text[1];
                }
            }
            return '\0';
        }

        public static char SpecialChar(char escape)
        {
            switch (escape)
            {
                case '0': return '\0';
                case 'a': return '\a';
                case 'b': return '\b';
                case 'f': return '\f';
                case 'n': return '\n';
                case 'r': return '\r';
                case 't': return '\t';
                case 'v': return '\v';
                default:
                    return escape;
            }
        }

        public static char UnicodeChar(string hex)
        {
            return Convert.ToChar(Convert.ToInt32(hex, 16));
        }

    }
}
