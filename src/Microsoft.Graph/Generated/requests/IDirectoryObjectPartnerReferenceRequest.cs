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
    /// The interface IDirectoryObjectPartnerReferenceRequest.
    /// </summary>
    public partial interface IDirectoryObjectPartnerReferenceRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DirectoryObjectPartnerReference using POST.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToCreate">The DirectoryObjectPartnerReference to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DirectoryObjectPartnerReference.</returns>
        System.Threading.Tasks.Task<DirectoryObjectPartnerReference> CreateAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DirectoryObjectPartnerReference using POST and returns a <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToCreate">The DirectoryObjectPartnerReference to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryObjectPartnerReference>> CreateResponseAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DirectoryObjectPartnerReference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DirectoryObjectPartnerReference and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DirectoryObjectPartnerReference.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DirectoryObjectPartnerReference.</returns>
        System.Threading.Tasks.Task<DirectoryObjectPartnerReference> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DirectoryObjectPartnerReference and returns a <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryObjectPartnerReference>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DirectoryObjectPartnerReference using PATCH.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToUpdate">The DirectoryObjectPartnerReference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DirectoryObjectPartnerReference.</returns>
        System.Threading.Tasks.Task<DirectoryObjectPartnerReference> UpdateAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DirectoryObjectPartnerReference using PATCH and returns a <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToUpdate">The DirectoryObjectPartnerReference to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryObjectPartnerReference>> UpdateResponseAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DirectoryObjectPartnerReference using PUT.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToUpdate">The DirectoryObjectPartnerReference object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DirectoryObjectPartnerReference> PutAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DirectoryObjectPartnerReference using PUT and returns a <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> object.
        /// </summary>
        /// <param name="directoryObjectPartnerReferenceToUpdate">The DirectoryObjectPartnerReference object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DirectoryObjectPartnerReference}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DirectoryObjectPartnerReference>> PutResponseAsync(DirectoryObjectPartnerReference directoryObjectPartnerReferenceToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectPartnerReferenceRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectPartnerReferenceRequest Expand(Expression<Func<DirectoryObjectPartnerReference, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectPartnerReferenceRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDirectoryObjectPartnerReferenceRequest Select(Expression<Func<DirectoryObjectPartnerReference, object>> selectExpression);

    }
}
