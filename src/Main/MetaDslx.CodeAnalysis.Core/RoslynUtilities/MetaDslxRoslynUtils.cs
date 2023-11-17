using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Roslyn.Utilities
{
    public static class MetaDslxRoslynUtils
    {
        private static readonly Microsoft.CodeAnalysis.DiagnosticFormatter Formatter = new Microsoft.CodeAnalysis.DiagnosticFormatter();

        public static Microsoft.CodeAnalysis.Diagnostic ToMicrosoft(this MetaDslx.CodeAnalysis.Diagnostic diagnostic)
        {
            return Microsoft.CodeAnalysis.Diagnostic.Create(
                descriptor: diagnostic.Descriptor.ToMicrosoft(),
                location: diagnostic.Location.ToMicrosoft(),
                diagnostic.Arguments.ToArray());
        }

        public static Microsoft.CodeAnalysis.DiagnosticDescriptor ToMicrosoft(this MetaDslx.CodeAnalysis.DiagnosticDescriptor descriptor)
        {
            return new Microsoft.CodeAnalysis.DiagnosticDescriptor(
                id: descriptor.Id, title: descriptor.Title, messageFormat: descriptor.MessageFormat,
                category: descriptor.Category, defaultSeverity: descriptor.DefaultSeverity.ToMicrosoft(),
                isEnabledByDefault: descriptor.IsEnabledByDefault, description: descriptor.Description,
                helpLinkUri: descriptor.HelpLinkUri, customTags: descriptor.CustomTags.ToArray());
        }

        public static Microsoft.CodeAnalysis.DiagnosticSeverity ToMicrosoft(this MetaDslx.CodeAnalysis.DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case MetaDslx.CodeAnalysis.DiagnosticSeverity.Hidden:
                    return Microsoft.CodeAnalysis.DiagnosticSeverity.Hidden;
                case MetaDslx.CodeAnalysis.DiagnosticSeverity.Info:
                    return Microsoft.CodeAnalysis.DiagnosticSeverity.Info;
                case MetaDslx.CodeAnalysis.DiagnosticSeverity.Warning:
                    return Microsoft.CodeAnalysis.DiagnosticSeverity.Warning;
                case MetaDslx.CodeAnalysis.DiagnosticSeverity.Error:
                    return Microsoft.CodeAnalysis.DiagnosticSeverity.Error;
                default:
                    return Microsoft.CodeAnalysis.DiagnosticSeverity.Error;
            }
        }

        public static Microsoft.CodeAnalysis.Location ToMicrosoft(this MetaDslx.CodeAnalysis.Location location)
        {
            return Microsoft.CodeAnalysis.Location.Create(location.GetLineSpan().Path ?? string.Empty, location.SourceSpan.ToMicrosoft(), location.GetLineSpan().Span.ToMicrosoft());
        }

        public static Microsoft.CodeAnalysis.Text.TextSpan ToMicrosoft(this MetaDslx.CodeAnalysis.Text.TextSpan textSpan)
        {
            return Microsoft.CodeAnalysis.Text.TextSpan.FromBounds(textSpan.Start, textSpan.End);
        }

        public static Microsoft.CodeAnalysis.FileLinePositionSpan ToMicrosoft(this MetaDslx.CodeAnalysis.FileLinePositionSpan span)
        {
            return new Microsoft.CodeAnalysis.FileLinePositionSpan(span.Path, span.StartLinePosition.ToMicrosoft(), span.EndLinePosition.ToMicrosoft());
        }

        public static Microsoft.CodeAnalysis.Text.LinePositionSpan ToMicrosoft(this MetaDslx.CodeAnalysis.Text.LinePositionSpan span)
        {
            return new Microsoft.CodeAnalysis.Text.LinePositionSpan(span.Start.ToMicrosoft(), span.End.ToMicrosoft());
        }

        public static Microsoft.CodeAnalysis.Text.LinePosition ToMicrosoft(this MetaDslx.CodeAnalysis.Text.LinePosition position)
        {
            return new Microsoft.CodeAnalysis.Text.LinePosition(position.Line, position.Character);
        }

        public static MetaDslx.CodeAnalysis.Diagnostic ToMetaDslx(this Microsoft.CodeAnalysis.Diagnostic diagnostic)
        {
            return MetaDslx.CodeAnalysis.Diagnostic.Create(
                descriptor: diagnostic.Descriptor.ToMetaDslx(Formatter.Format(diagnostic)),
                location: diagnostic.Location.ToMetaDslx());
        }

        public static MetaDslx.CodeAnalysis.DiagnosticDescriptor ToMetaDslx(this Microsoft.CodeAnalysis.DiagnosticDescriptor descriptor, string message)
        {
            return new MetaDslx.CodeAnalysis.DiagnosticDescriptor(
                id: descriptor.Id, title: descriptor.Title.ToString(), messageFormat: message,
                category: descriptor.Category, defaultSeverity: descriptor.DefaultSeverity.ToMetaDslx(),
                isEnabledByDefault: descriptor.IsEnabledByDefault, description: descriptor.Description.ToString(),
                helpLinkUri: descriptor.HelpLinkUri, customTags: descriptor.CustomTags.ToArray());
        }

        public static MetaDslx.CodeAnalysis.DiagnosticSeverity ToMetaDslx(this Microsoft.CodeAnalysis.DiagnosticSeverity severity)
        {
            switch (severity)
            {
                case Microsoft.CodeAnalysis.DiagnosticSeverity.Hidden:
                    return MetaDslx.CodeAnalysis.DiagnosticSeverity.Hidden;
                case Microsoft.CodeAnalysis.DiagnosticSeverity.Info:
                    return MetaDslx.CodeAnalysis.DiagnosticSeverity.Info;
                case Microsoft.CodeAnalysis.DiagnosticSeverity.Warning:
                    return MetaDslx.CodeAnalysis.DiagnosticSeverity.Warning;
                case Microsoft.CodeAnalysis.DiagnosticSeverity.Error:
                    return MetaDslx.CodeAnalysis.DiagnosticSeverity.Error;
                default:
                    return MetaDslx.CodeAnalysis.DiagnosticSeverity.Error;
            }
        }

        public static MetaDslx.CodeAnalysis.Location ToMetaDslx(this Microsoft.CodeAnalysis.Location location)
        {
            var path = location.GetLineSpan().Path ?? string.Empty;
            return MetaDslx.CodeAnalysis.Location.Create(path, location.SourceSpan.ToMetaDslx(), location.GetLineSpan().Span.ToMetaDslx());
        }

        public static MetaDslx.CodeAnalysis.Text.TextSpan ToMetaDslx(this Microsoft.CodeAnalysis.Text.TextSpan textSpan)
        {
            return MetaDslx.CodeAnalysis.Text.TextSpan.FromBounds(textSpan.Start, textSpan.End);
        }

        public static MetaDslx.CodeAnalysis.FileLinePositionSpan ToMetaDslx(this Microsoft.CodeAnalysis.FileLinePositionSpan span)
        {
            return new MetaDslx.CodeAnalysis.FileLinePositionSpan(span.Path, span.StartLinePosition.ToMetaDslx(), span.EndLinePosition.ToMetaDslx());
        }

        public static MetaDslx.CodeAnalysis.Text.LinePositionSpan ToMetaDslx(this Microsoft.CodeAnalysis.Text.LinePositionSpan span)
        {
            return new MetaDslx.CodeAnalysis.Text.LinePositionSpan(span.Start.ToMetaDslx(), span.End.ToMetaDslx());
        }

        public static MetaDslx.CodeAnalysis.Text.LinePosition ToMetaDslx(this Microsoft.CodeAnalysis.Text.LinePosition position)
        {
            return new MetaDslx.CodeAnalysis.Text.LinePosition(position.Line, position.Character);
        }
    }
}
