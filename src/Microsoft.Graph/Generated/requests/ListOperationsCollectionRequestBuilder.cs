// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type ListOperationsCollectionRequestBuilder.
    /// </summary>
    public partial class ListOperationsCollectionRequestBuilder : BaseRequestBuilder, IListOperationsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new ListOperationsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public ListOperationsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IListOperationsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IListOperationsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new ListOperationsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IRichLongRunningOperationRequestBuilder"/> for the specified ListRichLongRunningOperation.
        /// </summary>
        /// <param name="id">The ID for the ListRichLongRunningOperation.</param>
        /// <returns>The <see cref="IRichLongRunningOperationRequestBuilder"/>.</returns>
        public IRichLongRunningOperationRequestBuilder this[string id]
        {
            get
            {
                return new RichLongRunningOperationRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
