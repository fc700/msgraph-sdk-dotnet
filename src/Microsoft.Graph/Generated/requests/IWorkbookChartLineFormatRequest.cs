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
    /// The interface IWorkbookChartLineFormatRequest.
    /// </summary>
    public partial interface IWorkbookChartLineFormatRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WorkbookChartLineFormat using POST.
        /// </summary>
        /// <param name="workbookChartLineFormatToCreate">The WorkbookChartLineFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> CreateAsync(WorkbookChartLineFormat workbookChartLineFormatToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified WorkbookChartLineFormat using POST and returns a <see cref="GraphResponse{WorkbookChartLineFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLineFormatToCreate">The WorkbookChartLineFormat to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLineFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLineFormat>> CreateResponseAsync(WorkbookChartLineFormat workbookChartLineFormatToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartLineFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified WorkbookChartLineFormat and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartLineFormat.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified WorkbookChartLineFormat and returns a <see cref="GraphResponse{WorkbookChartLineFormat}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLineFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLineFormat>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PATCH.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WorkbookChartLineFormat.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> UpdateAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PATCH and returns a <see cref="GraphResponse{WorkbookChartLineFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{WorkbookChartLineFormat}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLineFormat>> UpdateResponseAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PUT.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<WorkbookChartLineFormat> PutAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified WorkbookChartLineFormat using PUT and returns a <see cref="GraphResponse{WorkbookChartLineFormat}"/> object.
        /// </summary>
        /// <param name="workbookChartLineFormatToUpdate">The WorkbookChartLineFormat object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{WorkbookChartLineFormat}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<WorkbookChartLineFormat>> PutResponseAsync(WorkbookChartLineFormat workbookChartLineFormatToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Expand(Expression<Func<WorkbookChartLineFormat, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWorkbookChartLineFormatRequest Select(Expression<Func<WorkbookChartLineFormat, object>> selectExpression);

    }
}
