// Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

using Microsoft.CodeAnalysis;

namespace MetaDslx.CodeAnalysis
{
    /// <summary>
    /// Represents a <see cref="SyntaxNode"/> visitor that visits only the single SyntaxNode
    /// passed into its Visit method and produces 
    /// a value of the type specified by the <typeparamref name="TResult"/> parameter.
    /// </summary>
    /// <typeparam name="TArg">
    /// The type of the additional parameters passed to the visitor's Visit method.
    /// </typeparam>
    /// <typeparam name="TResult">
    /// The type of the return value this visitor's Visit method.
    /// </typeparam>
    public abstract partial class SyntaxVisitor<TArg, TResult>
    {
        public virtual TResult Visit(SyntaxNode? node, TArg argument)
        {
            if (node != null)
            {
                return node.Accept(this, argument);
            }

            // should not come here too often so we will put this at the end of the method.
#pragma warning disable CS8603
            return default;
#pragma warning restore CS8603
        }

        public virtual TResult DefaultVisit(SyntaxNode? node, TArg argument)
        {
#pragma warning disable CS8603
            return default;
#pragma warning restore CS8603
        }
    }

    /// <summary>
    /// Represents a <see cref="SyntaxNode"/> visitor that visits only the single SyntaxNode
    /// passed into its Visit method and produces 
    /// a value of the type specified by the <typeparamref name="TResult"/> parameter.
    /// </summary>
    /// <typeparam name="TResult">
    /// The type of the return value this visitor's Visit method.
    /// </typeparam>
    public abstract partial class SyntaxVisitor<TResult>
    {
        public virtual TResult Visit(SyntaxNode? node)
        {
            if (node != null)
            {
                return node.Accept(this);
            }

            // should not come here too often so we will put this at the end of the method.
#pragma warning disable CS8603
            return default;
#pragma warning restore CS8603
        }

        public virtual TResult DefaultVisit(SyntaxNode? node)
        {
#pragma warning disable CS8603
            return default;
#pragma warning restore CS8603
        }
    }

    /// <summary>
    /// Represents a <see cref="SyntaxNode"/> visitor that visits only the single CSharpSyntaxNode
    /// passed into its Visit method.
    /// </summary>
    public abstract partial class SyntaxVisitor
    {
        public virtual void Visit(SyntaxNode? node)
        {
            if (node != null)
            {
                node.Accept(this);
            }
        }

        public virtual void DefaultVisit(SyntaxNode? node)
        {
        }
    }
}
