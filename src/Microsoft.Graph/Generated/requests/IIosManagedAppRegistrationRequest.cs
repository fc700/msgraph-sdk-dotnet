// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IIosManagedAppRegistrationRequest.
    /// </summary>
    public partial interface IIosManagedAppRegistrationRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified IosManagedAppRegistration using POST.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToCreate">The IosManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created IosManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<IosManagedAppRegistration> CreateAsync(IosManagedAppRegistration iosManagedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified IosManagedAppRegistration using POST and returns a <see cref="GraphResponse{IosManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToCreate">The IosManagedAppRegistration to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppRegistration>> CreateResponseAsync(IosManagedAppRegistration iosManagedAppRegistrationToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified IosManagedAppRegistration and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosManagedAppRegistration.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The IosManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<IosManagedAppRegistration> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified IosManagedAppRegistration and returns a <see cref="GraphResponse{IosManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{IosManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppRegistration>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosManagedAppRegistration using PATCH.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToUpdate">The IosManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated IosManagedAppRegistration.</returns>
        System.Threading.Tasks.Task<IosManagedAppRegistration> UpdateAsync(IosManagedAppRegistration iosManagedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosManagedAppRegistration using PATCH and returns a <see cref="GraphResponse{IosManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToUpdate">The IosManagedAppRegistration to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{IosManagedAppRegistration}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppRegistration>> UpdateResponseAsync(IosManagedAppRegistration iosManagedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosManagedAppRegistration using PUT.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToUpdate">The IosManagedAppRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<IosManagedAppRegistration> PutAsync(IosManagedAppRegistration iosManagedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified IosManagedAppRegistration using PUT and returns a <see cref="GraphResponse{IosManagedAppRegistration}"/> object.
        /// </summary>
        /// <param name="iosManagedAppRegistrationToUpdate">The IosManagedAppRegistration object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{IosManagedAppRegistration}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<IosManagedAppRegistration>> PutResponseAsync(IosManagedAppRegistration iosManagedAppRegistrationToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppRegistrationRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppRegistrationRequest Expand(Expression<Func<IosManagedAppRegistration, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppRegistrationRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IIosManagedAppRegistrationRequest Select(Expression<Func<IosManagedAppRegistration, object>> selectExpression);

    }
}
