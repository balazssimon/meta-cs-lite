using MetaDslx.CodeAnalysis.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public class DeclarationTreeBuilderVisitor : SyntaxVisitor
    {
        private readonly SyntaxTree _syntaxTree;
        private readonly string _scriptClassName;
        private readonly bool _isSubmission;
        private SyntaxNode? _rootSyntax;
        private SingleDeclarationBuilder? _rootDeclaration;
        private Stack<SingleDeclarationBuilder>? _declarationStack;
        private SingleDeclarationBuilder? _currentDeclaration;
        private Stack<bool>? _enabledStack;
        private bool _enabled;
        private Stack<bool>? _isNameStack;
        private bool _isName;
        private Stack<SingleDeclarationBuilder?>? _currentScopeStack;
        private SingleDeclarationBuilder? _currentScope;

        protected DeclarationTreeBuilderVisitor(SyntaxTree syntaxTree, string scriptClassName, bool isSubmission) 
        {
            if (syntaxTree == null) throw new ArgumentNullException(nameof(syntaxTree));
            _syntaxTree = syntaxTree;
            _scriptClassName = scriptClassName;
            _isSubmission = isSubmission;
        }

        public Language Language => _syntaxTree.Language;
        public SyntaxTree SyntaxTree => _syntaxTree;
        public string ScriptClassName => _scriptClassName;
        public bool IsSubmission => _isSubmission;
        public bool IsEnabled => _enabled;

        protected RootSingleDeclaration CreateRoot(SyntaxNode syntax, Type type)
        {
            if (_syntaxTree.Options.Kind != SourceCodeKind.Regular)
            {
                return this.CreateScriptRootDeclaration(syntax, type);
            }
            else
            {
                return this.CreateRegularRootDeclaration(syntax, type);
            }
        }

        protected RootSingleDeclaration CreateRootDeclaration(SyntaxNode syntax, Type type)
        {
            RootSingleDeclaration result;
            _rootSyntax = syntax;
            _rootDeclaration = new SingleDeclarationBuilder(syntax.GetReference(), type);
            _declarationStack = new Stack<SingleDeclarationBuilder>();
            _enabledStack = new Stack<bool>();
            _isNameStack = new Stack<bool>();
            _currentScopeStack = new Stack<SingleDeclarationBuilder?>();
            try
            {
                _enabled = true;
                _isName = false;
                _currentDeclaration = _rootDeclaration;
                _currentScope = _rootDeclaration;
                syntax.Accept(this);
            }
            finally
            {
                result = (RootSingleDeclaration)_rootDeclaration.ToImmutableAndFree(root: true)[0];
                _currentScopeStack = null;
                _isNameStack = null;
                _enabledStack = null;
                _declarationStack = null;
                _rootDeclaration = null;
                _rootSyntax = null;
            }
            return result;
        }

        protected virtual RootSingleDeclaration CreateRegularRootDeclaration(SyntaxNode node, Type type)
        {
            return this.CreateRootDeclaration(node, type);
        }

        protected virtual RootSingleDeclaration CreateScriptRootDeclaration(SyntaxNode node, Type type)
        {
            return this.CreateRootDeclaration(node, type);
        }

        private void Disable()
        {
            _enabledStack.Push(_enabled);
            _enabled = false;
        }

        private void Enable()
        {
            _enabled = _enabledStack.Pop();
        }

        protected virtual void BeginAnnotation(SyntaxNodeOrToken syntax, Annotation annotation)
        {
            if (annotation is IValueAnnotation) Disable();
            if (annotation is IScopeAnnotation scope && scope.IsLocal && syntax != _rootSyntax) Disable();
        }

        protected virtual void EndAnnotation(SyntaxNodeOrToken syntax, Annotation annotation)
        {
            if (annotation is IScopeAnnotation scope && scope.IsLocal && syntax != _rootSyntax) Enable();
            if (annotation is IValueAnnotation) Enable();
        }

        protected virtual void BeginDefine(SyntaxNodeOrToken syntax, DefineAnnotation annotation)
        {
            if (!_enabled) return;
            _declarationStack.Push(_currentDeclaration);
            _currentDeclaration = new SingleDeclarationBuilder(syntax.GetReference(), annotation.Type);
        }

        protected virtual void EndDefine(SyntaxNodeOrToken syntax, DefineAnnotation annotation)
        {
            if (!_enabled) return;
            var declarations = _currentDeclaration.ToImmutableAndFree(root: false);
            _currentScope.AddChildren(declarations);
            _currentDeclaration = _declarationStack.Pop();
        }

        protected virtual void BeginName(SyntaxNodeOrToken syntax, NameAnnotation annotation)
        {
            if (!_enabled) return;
            _isNameStack.Push(_isName); 
            _isName = true;
            if (_currentDeclaration == _rootDeclaration)
            {
                _rootDeclaration.AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_DeclarationError, syntax.GetLocation(), "The root declaration should not have a name (are you missing a [Define] annotation?)"));
            }
        }

        protected virtual void EndName(SyntaxNodeOrToken syntax, NameAnnotation annotation)
        {
            if (!_enabled) return;
            _isName = _isNameStack.Pop();
        }

        protected virtual void BeginQualifier(SyntaxNodeOrToken syntax, QualifierAnnotation annotation)
        {
            if (!_enabled) return;
            if (_isName && _currentDeclaration is not null) _currentDeclaration.BeginQualifier(); 
        }

        protected virtual void EndQualifier(SyntaxNodeOrToken syntax, QualifierAnnotation annotation)
        {
            if (!_enabled) return;
            if (_isName && _currentDeclaration is not null) _currentDeclaration.EndQualifier();
        }

        protected virtual void BeginIdentifier(SyntaxNodeOrToken syntax, IdentifierAnnotation annotation)
        {
            if (_enabled && _isName && _currentDeclaration is not null) _currentDeclaration.AddIdentifier(syntax.ToString(), syntax.ToString(), (SourceLocation)syntax.GetLocation());
            Disable();
        }

        protected virtual void EndIdentifier(SyntaxNodeOrToken syntax, IdentifierAnnotation annotation)
        {
            Enable();
        }

        protected virtual void BeginScope(SyntaxNodeOrToken syntax, ScopeAnnotation annotation)
        {
            if (!_enabled) return;
            _currentScopeStack.Push(_currentScope);
            _currentScope = _currentDeclaration;
        }

        protected virtual void EndScope(SyntaxNodeOrToken syntax, ScopeAnnotation annotation)
        {
            if (!_enabled) return;
            _currentScope = _currentScopeStack.Pop();
        }

        protected virtual void BeginDefinedType(SyntaxNodeOrToken syntax, DefinedTypeAnnotation annotation)
        {
            if (!_enabled) return;
            _currentDeclaration.Type = annotation.Type;
        }

        protected virtual void EndDefinedType(SyntaxNodeOrToken syntax, DefinedTypeAnnotation annotation)
        {
            if (!_enabled) return;
        }

        protected virtual void BeginMerge(SyntaxNodeOrToken syntax, MergeAnnotation annotation)
        {
            if (!_enabled) return;
            _currentDeclaration.CanMerge = annotation.Allow;
        }

        protected virtual void EndMerge(SyntaxNodeOrToken syntax, MergeAnnotation annotation)
        {
            if (!_enabled) return;
        }

        protected virtual void BeginNesting(SyntaxNodeOrToken syntax, NestingAnnotation annotation)
        {
            if (!_enabled) return;
            _currentDeclaration.NestingType = annotation.Type;
            _currentDeclaration.NestingProperty = annotation.Property;
        }

        protected virtual void EndNesting(SyntaxNodeOrToken syntax, NestingAnnotation annotation)
        {
            if (!_enabled) return;
        }
    }
}
