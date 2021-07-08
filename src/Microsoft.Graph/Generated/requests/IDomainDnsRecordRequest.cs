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
    /// The interface IDomainDnsRecordRequest.
    /// </summary>
    public partial interface IDomainDnsRecordRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified DomainDnsRecord using POST.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> CreateAsync(DomainDnsRecord domainDnsRecordToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates the specified DomainDnsRecord using POST and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToCreate">The DomainDnsRecord to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> CreateResponseAsync(DomainDnsRecord domainDnsRecordToCreate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Deletes the specified DomainDnsRecord and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DomainDnsRecord.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> GetAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Gets the specified DomainDnsRecord and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated DomainDnsRecord.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> UpdateAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsRecord using PATCH and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{DomainDnsRecord}"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> UpdateResponseAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsRecord using PUT.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task<DomainDnsRecord> PutAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Updates the specified DomainDnsRecord using PUT and returns a <see cref="GraphResponse{DomainDnsRecord}"/> object.
        /// </summary>
        /// <param name="domainDnsRecordToUpdate">The DomainDnsRecord object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse{DomainDnsRecord}"/> to await.</returns>
        System.Threading.Tasks.Task<GraphResponse<DomainDnsRecord>> PutResponseAsync(DomainDnsRecord domainDnsRecordToUpdate, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Expand(Expression<Func<DomainDnsRecord, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IDomainDnsRecordRequest Select(Expression<Func<DomainDnsRecord, object>> selectExpression);

    }
}
