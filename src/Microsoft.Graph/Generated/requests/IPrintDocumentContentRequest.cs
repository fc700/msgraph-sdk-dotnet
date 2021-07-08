// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: IStreamRequest.cs.tt

namespace Microsoft.Graph
{
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;

    /// <summary>
    /// The interface IPrintDocumentContentRequest.
    /// </summary>
    public partial interface IPrintDocumentContentRequest : IBaseRequest
    {

        /// <summary>
        /// Gets the stream.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The stream.</returns>
        System.Threading.Tasks.Task<Stream> GetAsync(CancellationToken cancellationToken = default(CancellationToken), HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);

        /// <summary>
        /// Gets the <see cref="GraphResponse"/> object of the request.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The <see cref="GraphResponse"/> object of the request.</returns>
        System.Threading.Tasks.Task<GraphResponse> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken), HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);


        /// <summary>
        /// PUTs the specified stream.
        /// </summary>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The updated stream.</returns>
        System.Threading.Tasks.Task<Stream> PutAsync(Stream content, CancellationToken cancellationToken = default(CancellationToken), HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);

        /// <summary>
        /// PUTs the specified stream and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="content">The stream to PUT.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <param name="completionOption">The <see cref="HttpCompletionOption"/> to pass to the <see cref="IHttpProvider"/> on send.</param>
        /// <returns>The <see cref="GraphResponse"/> object returned by the PUT call.</returns>
        System.Threading.Tasks.Task<GraphResponse> PutResponseAsync(Stream content, CancellationToken cancellationToken = default(CancellationToken), HttpCompletionOption completionOption = HttpCompletionOption.ResponseContentRead);
    
    }
}
