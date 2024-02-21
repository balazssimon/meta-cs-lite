using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.CompilerServices;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Source;

namespace MetaDslx.Modeling
{
    public class ValueInfo
    {
        private static readonly ConditionalWeakTable<object, object> s_tags = new ConditionalWeakTable<object, object>();
        private static readonly ConditionalWeakTable<object, object> s_symbols = new ConditionalWeakTable<object, object>();

        private readonly object _target;

        public ValueInfo(object target)
        {
            if (target is IModelObject || target is Box)
            {
                _target = target;
            }
            else
            {
                throw new ArgumentException("Target must be either a model object or a box.", nameof(target));
            }
        }

        public object? Target => _target;

        public Model Model
        {
            get
            {
                if (_target is IModelObject mobj) return mobj.MModel;
                if (_target is Box box) return box.Model;
                return null;
            }
        }

        public TSymbol? GetSymbol<TSymbol>()
            where TSymbol : Symbol
        {
            return Symbol as TSymbol;
        }

        public TSyntax? GetSyntax<TSyntax>()
            where TSyntax : SyntaxNode
        {
            return Syntax.AsNode() as TSyntax;
        }

        public Symbol? Symbol
        {
            get
            {
                if (s_symbols.TryGetValue(Target, out var symbol)) return symbol as Symbol;
                else return null;
            }
            set
            {
                if (s_symbols.TryGetValue(Target, out var existingSymbol))
                {
                    if (value != existingSymbol)
                    {
                        s_symbols.Remove(Target);
                        if (value is not null) s_symbols.Add(Target, value);
                    }
                }
                else
                {
                    if (value is not null) s_symbols.Add(Target, value);
                }
            }
        }

        public Microsoft.CodeAnalysis.ISymbol? CSharpSymbol => (Symbol as ICSharpSymbol)?.CSharpSymbol;

        public SyntaxNodeOrToken Syntax
        {
            get
            {
                if (Symbol is ISourceSymbol sourceSymbol) return sourceSymbol.DeclaringSyntaxReference;
                else if (s_symbols.TryGetValue(Target, out var syntax)) return syntax is SyntaxNodeOrToken snt ? snt : default;
                else return default;
            }
            set
            {
                if (s_symbols.TryGetValue(Target, out var existingSymbol))
                {
                    SyntaxNodeOrToken oldSyntax = default;
                    if (existingSymbol is ISourceSymbol sourceSymbol) oldSyntax = sourceSymbol.DeclaringSyntaxReference;
                    else if (existingSymbol is SyntaxNodeOrToken snt) oldSyntax = snt;
                    if (value != oldSyntax)
                    {
                        s_symbols.Remove(Target);
                        if (!value.IsNull) s_symbols.Add(Target, value);
                    }
                }
                else
                {
                    if (!value.IsNull) s_symbols.Add(Target, value);
                }
            }
        }

        public SourceLocation? SourceLocation
        {
            get
            {
                if (Symbol is ISourceSymbol sourceSymbol)
                {
                    return sourceSymbol.Location;
                }
                else
                {
                    var syntax = Syntax;
                    if (!syntax.IsNull) return syntax.GetLocation() as SourceLocation;
                }
                if (s_symbols.TryGetValue(Target, out var location)) return location as SourceLocation;
                else return default;
            }
            set
            {
                if (s_symbols.TryGetValue(Target, out var existingSymbol))
                {
                    SourceLocation oldLocation;
                    if (existingSymbol is ISourceSymbol sourceSymbol) oldLocation = sourceSymbol.Location;
                    else if (existingSymbol is SyntaxNodeOrToken snt) oldLocation = snt.GetLocation() as SourceLocation;
                    else oldLocation = existingSymbol as SourceLocation;
                    if (value != oldLocation)
                    {
                        s_symbols.Remove(Target);
                        if (value is not null) s_symbols.Add(Target, value);
                    }
                }
                else
                {
                    if (value is not null) s_symbols.Add(Target, value);
                }
            }
        }

        public Location? Location
        {
            get
            {
                if (Symbol is ISourceSymbol sourceSymbol)
                {
                    return sourceSymbol.Location;
                }
                else
                {
                    var syntax = Syntax;
                    if (!syntax.IsNull) return syntax.GetLocation() as SourceLocation;
                }
                if (s_symbols.TryGetValue(Target, out var location)) return location as Location;
                else return default;
            }
            set
            {
                if (s_symbols.TryGetValue(Target, out var existingSymbol))
                {
                    Location oldLocation;
                    if (existingSymbol is ISourceSymbol sourceSymbol) oldLocation = sourceSymbol.Location;
                    else if (existingSymbol is SyntaxNodeOrToken snt) oldLocation = snt.GetLocation();
                    else oldLocation = existingSymbol as Location;
                    if (value != oldLocation)
                    {
                        s_symbols.Remove(Target);
                        if (value is not null) s_symbols.Add(Target, value);
                    }
                }
                else
                {
                    if (value is not null) s_symbols.Add(Target, value);
                }
            }
        }

        public object? Tag
        {
            get
            {
                if (s_tags.TryGetValue(Target, out var tag)) return tag;
                else return null;
            }
            set
            {
                if (s_tags.TryGetValue(Target, out var existingTag))
                {
                    if (value != existingTag)
                    {
                        s_tags.Remove(Target);
                        if (value is not null) s_tags.Add(Target, value);
                    }
                }
                else
                {
                    if (value is not null) s_tags.Add(Target, value);
                }
            }
        }
    }
}
