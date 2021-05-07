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
    /// The type UserChatsCollectionRequestBuilder.
    /// </summary>
    public partial class UserChatsCollectionRequestBuilder : BaseRequestBuilder, IUserChatsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserChatsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserChatsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserChatsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserChatsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserChatsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IChatRequestBuilder"/> for the specified UserChat.
        /// </summary>
        /// <param name="id">The ID for the UserChat.</param>
        /// <returns>The <see cref="IChatRequestBuilder"/>.</returns>
        public IChatRequestBuilder this[string id]
        {
            get
            {
                return new ChatRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ChatGetAllMessages.
        /// </summary>
        /// <returns>The <see cref="IChatGetAllMessagesRequestBuilder"/>.</returns>
        public IChatGetAllMessagesRequestBuilder GetAllMessages()
        {
            return new ChatGetAllMessagesRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.getAllMessages"),
                this.Client);
        }
    }
}
