//-----------------------------------------------------------------------------
// <copyright file="ODataController.cs" company=".NET Foundation">
//      Copyright (c) .NET Foundation and Contributors. All rights reserved.
//      See License.txt in the project root for license information.
// </copyright>
//------------------------------------------------------------------------------

using Microsoft.AspNet.OData.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Attributes;
using Microsoft.OData;

namespace Microsoft.AspNetCore.OData.Routing.Controllers
{
    /// <summary>
    /// The base controller class for OData.
    /// </summary>
    [ODataAttributeRouting]
    public abstract class ODataController : ControllerBase
    {
        /// <summary>
        /// Creates an action result with the specified values that is a response to a POST operation with an entity
        /// to an entity set.
        /// </summary>
        /// <typeparam name="TEntity">The created entity type.</typeparam>
        /// <param name="entity">The created entity.</param>
        /// <returns>A <see cref="CreatedODataResult{TEntity}"/> with the specified values.</returns>
        /// <remarks>This function uses types that are AspNetCore-specific.</remarks>
        protected virtual CreatedODataResult<TEntity> Created<TEntity>(TEntity entity)
        {
            if (entity == null)
            {
                throw Error.ArgumentNull(nameof(entity));
            }

            return new CreatedODataResult<TEntity>(entity);
        }

        /// <summary>
        /// Creates an action result with the specified values that is a response to a PUT, PATCH, or a MERGE operation
        /// on an OData entity.
        /// </summary>
        /// <typeparam name="TEntity">The updated entity type.</typeparam>
        /// <param name="entity">The updated entity.</param>
        /// <returns>An <see cref="UpdatedODataResult{TEntity}"/> with the specified values.</returns>
        /// <remarks>This function uses types that are AspNetCore-specific.</remarks>
        protected virtual UpdatedODataResult<TEntity> Updated<TEntity>(TEntity entity)
        {
            if (entity == null)
            {
                throw Error.ArgumentNull(nameof(entity));
            }

            return new UpdatedODataResult<TEntity>(entity);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Bad Request (400) response.
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>A <see cref="BadRequestODataResult"/> with the specified values.</returns>
        public virtual BadRequestODataResult BadRequest(string message)
        {
            return new BadRequestODataResult(message);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Bad Request (400) response.
        /// </summary>
        /// <param name="odataError">Parameter of type <see cref="ODataError"/>.</param>
        /// <returns>A <see cref="BadRequestODataResult"/> with the specified values.</returns>
        protected virtual BadRequestODataResult BadRequest(ODataError odataError)
        {
            return new BadRequestODataResult(odataError);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Not Found (404) response.
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>A <see cref="NotFoundODataResult"/> with the specified values.</returns>
        protected virtual NotFoundODataResult NotFound(string message)
        {
            return new NotFoundODataResult(message);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Not Found (404) response.
        /// </summary>
        /// <param name="odataError">Parameter of type <see cref="ODataError"/>.</param>
        /// <returns>A <see cref="NotFoundODataResult"/> with the specified values.</returns>
        protected virtual NotFoundODataResult NotFound(ODataError odataError)
        {
            return new NotFoundODataResult(odataError);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Unauthorized (401) response.
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>An <see cref="UnauthorizedODataResult"/> with the specified values.</returns>
        protected virtual UnauthorizedODataResult Unauthorized(string message)
        {
            return new UnauthorizedODataResult(message);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Unauthorized (401) response.
        /// </summary>
        /// <param name="odataError">Parameter of type <see cref="ODataError"/>.</param>
        /// <returns>An <see cref="UnauthorizedODataResult"/> with the specified values.</returns>
        protected virtual UnauthorizedODataResult Unauthorized(ODataError odataError)
        {
            return new UnauthorizedODataResult(odataError);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Conflict (409) response.
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>A <see cref="ConflictODataResult"/> with the specified values.</returns>
        protected virtual ConflictODataResult Conflict(string message)
        {
            return new ConflictODataResult(message);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce a Conflict (409) response.
        /// </summary>
        /// <param name="odataError">Parameter of type <see cref="ODataError"/>.</param>
        /// <returns>A <see cref="ConflictODataResult"/> with the specified values.</returns>
        protected virtual ConflictODataResult Conflict(ODataError odataError)
        {
            return new ConflictODataResult(odataError);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce an UnprocessableEntity (422) response.
        /// </summary>
        /// <param name="message">Error Message</param>
        /// <returns>An <see cref="UnprocessableEntityODataResult"/> with the specified values.</returns>
        protected virtual UnprocessableEntityODataResult UnprocessableEntity(string message)
        {
            return new UnprocessableEntityODataResult(message);
        }

        /// <summary>
        /// Creates a <see cref="StatusCodeResult"/> that when executed will produce an UnprocessableEntity (422) response.
        /// </summary>
        /// <param name="odataError">Parameter of type <see cref="ODataError"/>.</param>
        /// <returns>An <see cref="UnprocessableEntityODataResult"/> with the specified values.</returns>
        protected virtual UnprocessableEntityODataResult UnprocessableEntity(ODataError odataError)
        {
            return new UnprocessableEntityODataResult(odataError);
        }

        /// <summary>
        /// Creates a <see cref="ActionResult"/> that when executed will produce an <see cref="ODataError"/> response.
        /// </summary>
        /// <param name="errorCode">Http Error code.</param>
        /// <param name="message">Http Error Message.</param>
        /// <returns>An <see cref="Microsoft.AspNet.OData.Results.ODataErrorResult"/> with the specified values.</returns>
        protected virtual ODataErrorResult ODataErrorResult(string errorCode, string message)
        {
            return new ODataErrorResult(errorCode, message);
        }

        /// <summary>
        /// Creates a <see cref="ActionResult"/> that when executed will produce an <see cref="ODataError"/> response.
        /// </summary>
        /// <param name="odataError"><see cref="ODataError"/>.</param>
        /// <returns>An <see cref="Microsoft.AspNet.OData.Results.ODataErrorResult"/> with the specified values.</returns>
        protected virtual ODataErrorResult ODataErrorResult(ODataError odataError)
        {
            return new ODataErrorResult(odataError);
        }
    }
}
