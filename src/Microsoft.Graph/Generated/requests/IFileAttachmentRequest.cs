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
    /// The interface IFileAttachmentRequest.
    /// </summary>
    public partial interface IFileAttachmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FileAttachment using POST.
        /// </summary>
        /// <param name="fileAttachmentToCreate">The FileAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileAttachment.</returns>
        System.Threading.Tasks.Task<FileAttachment> CreateAsync(FileAttachment fileAttachmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified FileAttachment using POST and returns a <see cref="GraphResponse{FileAttachment}"/> object.
        /// </summary>
        /// <param name="fileAttachmentToCreate">The FileAttachment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAttachment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAttachment>> CreateResponseAsync(FileAttachment fileAttachmentToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileAttachment and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileAttachment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileAttachment.</returns>
        System.Threading.Tasks.Task<FileAttachment> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileAttachment and returns a <see cref="GraphResponse{FileAttachment}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAttachment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAttachment>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAttachment using PATCH.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FileAttachment.</returns>
        System.Threading.Tasks.Task<FileAttachment> UpdateAsync(FileAttachment fileAttachmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAttachment using PATCH and returns a <see cref="GraphResponse{FileAttachment}"/> object.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FileAttachment}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAttachment>> UpdateResponseAsync(FileAttachment fileAttachmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAttachment using PUT.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<FileAttachment> PutAsync(FileAttachment fileAttachmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAttachment using PUT and returns a <see cref="GraphResponse{FileAttachment}"/> object.
        /// </summary>
        /// <param name="fileAttachmentToUpdate">The FileAttachment object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{FileAttachment}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAttachment>> PutResponseAsync(FileAttachment fileAttachmentToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Expand(Expression<Func<FileAttachment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFileAttachmentRequest Select(Expression<Func<FileAttachment, object>> selectExpression);

    }
}
