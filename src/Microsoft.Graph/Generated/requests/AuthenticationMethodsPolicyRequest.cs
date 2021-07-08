// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The type AuthenticationMethodsPolicyRequest.
    /// </summary>
    public partial class AuthenticationMethodsPolicyRequest : BaseRequest, IAuthenticationMethodsPolicyRequest
    {
        /// <summary>
        /// Constructs a new AuthenticationMethodsPolicyRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AuthenticationMethodsPolicyRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AuthenticationMethodsPolicy using POST.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToCreate">The AuthenticationMethodsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthenticationMethodsPolicy> CreateAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AuthenticationMethodsPolicy using POST and returns a <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToCreate">The AuthenticationMethodsPolicy to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsPolicy>> CreateResponseAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AuthenticationMethodsPolicy and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AuthenticationMethodsPolicy.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthenticationMethodsPolicy> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AuthenticationMethodsPolicy>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AuthenticationMethodsPolicy and returns a <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsPolicy>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AuthenticationMethodsPolicy>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AuthenticationMethodsPolicy using PATCH.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToUpdate">The AuthenticationMethodsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AuthenticationMethodsPolicy.</returns>
        public async System.Threading.Tasks.Task<AuthenticationMethodsPolicy> UpdateAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AuthenticationMethodsPolicy using PATCH and returns a <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToUpdate">The AuthenticationMethodsPolicy to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsPolicy>> UpdateResponseAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AuthenticationMethodsPolicy using PUT.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToUpdate">The AuthenticationMethodsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AuthenticationMethodsPolicy> PutAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AuthenticationMethodsPolicy using PUT and returns a <see cref="GraphResponse{AuthenticationMethodsPolicy}"/> object.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToUpdate">The AuthenticationMethodsPolicy object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AuthenticationMethodsPolicy}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AuthenticationMethodsPolicy>> PutResponseAsync(AuthenticationMethodsPolicy authenticationMethodsPolicyToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AuthenticationMethodsPolicy>(authenticationMethodsPolicyToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationMethodsPolicyRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationMethodsPolicyRequest Expand(Expression<Func<AuthenticationMethodsPolicy, object>> expandExpression)
        {
		    if (expandExpression == null)
            {
                throw new ArgumentNullException(nameof(expandExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(expandExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(expandExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$expand", value));
            }
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationMethodsPolicyRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAuthenticationMethodsPolicyRequest Select(Expression<Func<AuthenticationMethodsPolicy, object>> selectExpression)
        {
            if (selectExpression == null)
            {
                throw new ArgumentNullException(nameof(selectExpression));
            }
            string error;
            string value = ExpressionExtractHelper.ExtractMembers(selectExpression, out error);
            if (value == null)
            {
                throw new ArgumentException(error, nameof(selectExpression));
            }
            else
            {
                this.QueryOptions.Add(new QueryOption("$select", value));
            }
            return this;
        }

        /// <summary>
        /// Initializes any collection properties after deserialization, like next requests for paging.
        /// </summary>
        /// <param name="authenticationMethodsPolicyToInitialize">The <see cref="AuthenticationMethodsPolicy"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AuthenticationMethodsPolicy authenticationMethodsPolicyToInitialize)
        {

            if (authenticationMethodsPolicyToInitialize != null)
            {
                if (authenticationMethodsPolicyToInitialize.AuthenticationMethodConfigurations != null && authenticationMethodsPolicyToInitialize.AuthenticationMethodConfigurations.CurrentPage != null)
                {
                    authenticationMethodsPolicyToInitialize.AuthenticationMethodConfigurations.InitializeNextPageRequest(this.Client, authenticationMethodsPolicyToInitialize.AuthenticationMethodConfigurationsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    authenticationMethodsPolicyToInitialize.AuthenticationMethodConfigurations.AdditionalData = authenticationMethodsPolicyToInitialize.AdditionalData;
                }

            }


        }
    }
}
