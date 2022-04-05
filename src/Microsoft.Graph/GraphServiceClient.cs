﻿// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    using System;
    using System.Net.Http;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Microsoft.Graph.Core.Requests;
    using Microsoft.Kiota.Abstractions.Authentication;
    using Microsoft.Kiota.Authentication.Azure;
    using Microsoft.Kiota.Abstractions;
    using Azure.Core;

    /// <summary>
    /// A default client implementation.
    /// </summary>
    public class GraphServiceClient : BaseGraphServiceClient, IBaseClient
    {
        private static readonly Version assemblyVersion = typeof(GraphServiceClient).GetTypeInfo().Assembly.GetName().Version;
        private static readonly GraphClientOptions graphClientOptions = new GraphClientOptions
        {
            GraphServiceLibraryClientVersion = $"{assemblyVersion.Major}.{assemblyVersion.Minor}.{assemblyVersion.Build}",
            GraphServiceTargetVersion = "v1.0",
        };

        /// <summary>
        /// Constructs a new <see cref="GraphServiceClient"/>.
        /// </summary>
        /// <param name="requestAdapter">The custom <see cref="IRequestAdapter"/> to be used for making requests</param>
        public GraphServiceClient(IRequestAdapter requestAdapter): base(requestAdapter)
        {
            this.RequestAdapter = requestAdapter;
        }

        /// <summary>
        /// Constructs a new <see cref="GraphServiceClient"/>.
        /// </summary>
        /// <param name="tokenCredential">The <see cref="TokenCredential"/> for authenticating request messages.</param>
        /// <param name="scopes">List of scopes for the authentication context.</param>
        public GraphServiceClient(
            TokenCredential tokenCredential,
            IEnumerable<string> scopes = null
            ):this(new AzureIdentityAuthenticationProvider(tokenCredential, null,scopes?.ToArray() ?? Array.Empty<string>()))
        {
        }

        /// <summary>
        /// Constructs a new <see cref="GraphServiceClient"/>.
        /// </summary>
        /// <param name="authenticationProvider">The <see cref="IAuthenticationProvider"/> for authenticating request messages.</param>
        public GraphServiceClient(
            IAuthenticationProvider authenticationProvider
            ): this(new BaseGraphRequestAdapter(authenticationProvider,graphClientOptions))
        {
        }

        /// <summary>
        /// Constructs a new <see cref="GraphServiceClient"/>.
        /// </summary>
        /// <param name="httpClient">The customized <see cref="HttpClient"/> to be used for making requests</param>
        public GraphServiceClient(
            HttpClient httpClient):this(new BaseGraphRequestAdapter(new AnonymousAuthenticationProvider(), graphClientOptions, httpClient: httpClient))
        {
        }

        /// <summary>
        /// Gets the <see cref="IRequestAdapter"/> for sending requests.
        /// </summary>
        public IRequestAdapter RequestAdapter { get; set; }

        /// <summary>
        /// Gets the <see cref="BatchRequestBuilder"/> for building batch Requests
        /// </summary>
        public BatchRequestBuilder Batch
        {
            get
            {
                return new BatchRequestBuilder(this.RequestAdapter);
            }
        }
    }
}
