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
    /// The type SiteContentTypesCollectionRequestBuilder.
    /// </summary>
    public partial class SiteContentTypesCollectionRequestBuilder : BaseRequestBuilder, ISiteContentTypesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new SiteContentTypesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public SiteContentTypesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ISiteContentTypesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ISiteContentTypesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new SiteContentTypesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IContentTypeRequestBuilder"/> for the specified SiteContentType.
        /// </summary>
        /// <param name="id">The ID for the SiteContentType.</param>
        /// <returns>The <see cref="IContentTypeRequestBuilder"/>.</returns>
        public IContentTypeRequestBuilder this[string id]
        {
            get
            {
                return new ContentTypeRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ContentTypeAddCopy.
        /// </summary>
        /// <returns>The <see cref="IContentTypeAddCopyRequestBuilder"/>.</returns>
        public IContentTypeAddCopyRequestBuilder AddCopy(
            string contentType)
        {
            return new ContentTypeAddCopyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addCopy"),
                this.Client,
                contentType);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeAddCopyFromContentTypeHub.
        /// </summary>
        /// <returns>The <see cref="IContentTypeAddCopyFromContentTypeHubRequestBuilder"/>.</returns>
        public IContentTypeAddCopyFromContentTypeHubRequestBuilder AddCopyFromContentTypeHub(
            string contentTypeId)
        {
            return new ContentTypeAddCopyFromContentTypeHubRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.addCopyFromContentTypeHub"),
                this.Client,
                contentTypeId);
        }

        /// <summary>
        /// Gets the request builder for ContentTypeGetCompatibleHubContentTypes.
        /// </summary>
        /// <returns>The <see cref="IContentTypeGetCompatibleHubContentTypesRequestBuilder"/>.</returns>
        public IContentTypeGetCompatibleHubContentTypesRequestBuilder GetCompatibleHubContentTypes()
        {
            return new ContentTypeGetCompatibleHubContentTypesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getCompatibleHubContentTypes"),
                this.Client);
        }
    }
}
