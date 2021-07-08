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
    /// The interface IFileAssessmentRequestRequest.
    /// </summary>
    public partial interface IFileAssessmentRequestRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified FileAssessmentRequestObject using POST.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToCreate">The FileAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created FileAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<FileAssessmentRequestObject> CreateAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified FileAssessmentRequestObject using POST and returns a <see cref="GraphResponse{FileAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToCreate">The FileAssessmentRequestObject to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAssessmentRequestObject>> CreateResponseAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileAssessmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified FileAssessmentRequestObject and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileAssessmentRequestObject.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The FileAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<FileAssessmentRequestObject> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified FileAssessmentRequestObject and returns a <see cref="GraphResponse{FileAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{FileAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAssessmentRequestObject>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAssessmentRequestObject using PATCH.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToUpdate">The FileAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated FileAssessmentRequestObject.</returns>
        System.Threading.Tasks.Task<FileAssessmentRequestObject> UpdateAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAssessmentRequestObject using PATCH and returns a <see cref="GraphResponse{FileAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToUpdate">The FileAssessmentRequestObject to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{FileAssessmentRequestObject}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAssessmentRequestObject>> UpdateResponseAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAssessmentRequestObject using PUT.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToUpdate">The FileAssessmentRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<FileAssessmentRequestObject> PutAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified FileAssessmentRequestObject using PUT and returns a <see cref="GraphResponse{FileAssessmentRequestObject}"/> object.
        /// </summary>
        /// <param name="fileAssessmentRequestObjectToUpdate">The FileAssessmentRequestObject object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{FileAssessmentRequestObject}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<FileAssessmentRequestObject>> PutResponseAsync(FileAssessmentRequestObject fileAssessmentRequestObjectToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileAssessmentRequestRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IFileAssessmentRequestRequest Expand(Expression<Func<FileAssessmentRequestObject, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IFileAssessmentRequestRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IFileAssessmentRequestRequest Select(Expression<Func<FileAssessmentRequestObject, object>> selectExpression);

    }
}
