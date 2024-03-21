using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeGeneration;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetaDslx.Examples.Soal.Model
{
    internal class DocumentationReader
    {
        private static readonly Regex WhitespacePattern = new Regex("^[ \t]*");
        private static readonly Regex IdentifierPattern = new Regex("^@[a-zA-Z_][a-zA-Z0-9_]*");

        private static SoalModelMultiFactory _factory = new SoalModelMultiFactory();

        public static Documentation GetDocumentation(NamedElement elem)
        {
            if (elem is Parameter param) return ComputeParameterDocumentation(param);
            else return ComputeDocumentation(elem);
        }

        private static Documentation ComputeDocumentation(NamedElement elem)
        {
            if (elem is null) return null;
            var comment = GetDocumentationComment(elem);
            if (string.IsNullOrWhiteSpace(comment)) return null;
            var reader = new LineReader(comment);
            var insideCode = false;
            var result = _factory.Documentation(elem.MModel);
            var currentTag = _factory.DocumentationTag(elem.MModel);
            result.Tags.Add(currentTag);
            currentTag.Kind = DocumentationTagKind.Summary;
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line == null) break;
                if (line.StartsWith("```")) insideCode = !insideCode;
                if (!insideCode && line.StartsWith("@"))
                {
                    var match = IdentifierPattern.Match(line.ToString());
                    if (match.Success && match.Index == 0)
                    {
                        var tagName = match.Value;
                        var tagKind = DocumentationTagKind.Unknown;
                        switch (tagName)
                        {
                            case "@version": tagKind = DocumentationTagKind.Version; break;
                            case "@alpha": tagKind = DocumentationTagKind.Alpha; break;
                            case "@beta": tagKind = DocumentationTagKind.Beta; break;
                            case "@deprecated": tagKind = DocumentationTagKind.Deprecated; break;
                            case "@test": tagKind = DocumentationTagKind.Test; break;
                            case "@internal": tagKind = DocumentationTagKind.Internal; break;
                            case "@summary": tagKind = DocumentationTagKind.Summary; break;
                            case "@defaultValue": tagKind = DocumentationTagKind.DefaultValue; break;
                            case "@param": tagKind = DocumentationTagKind.Param; break;
                            case "@returns": tagKind = DocumentationTagKind.Returns; break;
                            case "@throws": tagKind = DocumentationTagKind.Throws; break;
                            case "@label": tagKind = DocumentationTagKind.Label; break;
                            case "@example": tagKind = DocumentationTagKind.Example; break;
                            case "@remarks": tagKind = DocumentationTagKind.Remarks; break;
                            default: tagKind = DocumentationTagKind.Unknown; break;
                        }
                        line = line.Slice(tagName.Length);
                        if (currentTag.Kind != DocumentationTagKind.Summary || tagKind != DocumentationTagKind.Summary)
                        {
                            currentTag = _factory.DocumentationTag(elem.MModel);
                            result.Tags.Add(currentTag);
                            currentTag.Name = tagName;
                            currentTag.Kind = tagKind;
                        }
                    }
                }
                currentTag.Lines.Add(line.ToString());
            }
            CleanupDocumentation(result);
            return result;
        }

        private static Documentation ComputeParameterDocumentation(Parameter param)
        {
            if (param is null) return null;
            var op = param.GetInnermostContainingObject<Operation>();
            if (op is null) return null;
            var doc = op.Documentation;
            if (doc is null) return null;
            var found = false;
            var result = _factory.Documentation(param.MModel);
            var currentTag = _factory.DocumentationTag(param.MModel);
            result.Tags.Add(currentTag);
            currentTag.Kind = DocumentationTagKind.Summary;
            if (param.Name is null)
            {
                var returnDoc = doc.Tags.FirstOrDefault(t => t.Kind == DocumentationTagKind.Returns);
                if (returnDoc is not null)
                {
                    currentTag.Lines.AddRange(returnDoc.Lines);
                    found = true;
                }
            }
            else
            {
                foreach (var tag in doc.Tags)
                {
                    if ((tag.Kind == DocumentationTagKind.Param || tag.Kind == DocumentationTagKind.Returns) && tag.Lines.Count > 0)
                    {
                        var firstLine = tag.Lines[0];
                        var dashIndex = firstLine.IndexOf('-');
                        if (dashIndex >= 0)
                        {
                            var paramName = firstLine.Substring(0, dashIndex).Trim();
                            if (param.Name == paramName)
                            {
                                found = true;
                                currentTag.Lines.Add(firstLine.Substring(dashIndex + 1).Trim());
                                for (var i = 1; i < tag.Lines.Count; ++i)
                                {
                                    currentTag.Lines.Add(tag.Lines[i]);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            if (found)
            {
                CleanupDocumentation(result);
                return result;
            }
            else
            {
                param.MModel.DeleteObject(result);
                return null;
            }
        }

        private static void CleanupDocumentation(Documentation doc)
        {
            foreach (var tag in doc.Tags)
            {
                while (tag.Lines.Count > 0)
                {
                    if (string.IsNullOrWhiteSpace(tag.Lines[0])) tag.Lines.RemoveAt(0);
                    else if (string.IsNullOrWhiteSpace(tag.Lines[tag.Lines.Count - 1])) tag.Lines.RemoveAt(tag.Lines.Count - 1);
                    else break;
                }
            }
        }

        public static string? GetDocumentationComment(IModelObject mobj)
        {
            var node = mobj.MSyntax.AsNode();
            if (node is null) return null;
            var firstToken = node.GetFirstToken(includeDocumentationComments: true).Node as InternalSyntaxToken;
            var trivia = firstToken?.GetLeadingTrivia()?.ToFullString()?.Trim();
            if (trivia is null) return null;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            var reader = new LineReader(trivia);
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                if (line == null) continue;
                var lineStr = line.ToString().TrimStart();
                if (lineStr.StartsWith("/// ")) sb.AppendLine(lineStr.Substring(4));
                else if (lineStr.StartsWith("///")) sb.AppendLine(lineStr.Substring(3));
            }
            return builder.ToStringAndFree();
        }
    }
}
