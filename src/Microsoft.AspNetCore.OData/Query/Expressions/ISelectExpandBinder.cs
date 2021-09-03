﻿//-----------------------------------------------------------------------------
// <copyright file="ISelectExpandBinder.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

using System.Linq;
using System.Linq.Expressions;
using Microsoft.OData.UriParser;

namespace Microsoft.AspNetCore.OData.Query.Expressions
{
    /// <summary>
    /// Exposes the ability to translate an OData $select or $expand parse tree represented by <see cref="SelectExpandClause"/> to
    /// an <see cref="Expression"/> and applies it to an <see cref="IQueryable"/> or an <see cref="object"/>.
    /// </summary>
    public interface ISelectExpandBinder
    {
        /// <summary>
        /// Translate an OData $select or $expand parse tree represented by <see cref="SelectExpandClause"/> to
        /// an <see cref="Expression"/> and applies it to an <see cref="IQueryable"/>.
        /// </summary>
        /// <param name="source">The original <see cref="IQueryable"/>.</param>
        /// <param name="context">An instance of the <see cref="SelectExpandBinderContext"/>.</param>
        /// <returns>The new <see cref="IQueryable"/> after the select/expand query has been applied to.</returns>
        IQueryable Bind(IQueryable source, SelectExpandBinderContext context);

        /// <summary>
        /// Translate an OData $select or $expand parse tree represented by <see cref="SelectExpandClause"/> to
        /// an <see cref="Expression"/> and applies it to an <see cref="object"/>.
        /// </summary>
        /// <param name="source">The original <see cref="object"/>.</param>
        /// <param name="context">An instance of the <see cref="SelectExpandBinderContext"/>.</param>
        /// <returns>The new <see cref="object"/> after the select/expand query has been applied to.</returns>
        object Bind(object source, SelectExpandBinderContext context);

        /// <summary>
        /// Translate an OData $select or $expand parse tree represented by <see cref="SelectExpandClause"/> to
        /// an <see cref="Expression"/>
        /// </summary>
        /// <param name="selectExpandQuery">The <see cref="SelectExpandQueryOption"/> which contains the $select and $expand query options.</param>
        /// <returns>An <see cref="Expression"/> which can be later applied to an <see cref="IQueryable"/> or an <see cref="object"/>.</returns>
        Expression GetProjectionLambda(SelectExpandQueryOption selectExpandQuery);
    }
}
