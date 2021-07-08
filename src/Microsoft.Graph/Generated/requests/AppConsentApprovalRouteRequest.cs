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
    /// The type AppConsentApprovalRouteRequest.
    /// </summary>
    public partial class AppConsentApprovalRouteRequest : BaseRequest, IAppConsentApprovalRouteRequest
    {
        /// <summary>
        /// Constructs a new AppConsentApprovalRouteRequest.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="options">Query and header option name value pairs for the request.</param>
        public AppConsentApprovalRouteRequest(
            string requestUrl,
            IBaseClient client,
            IEnumerable<Option> options)
            : base(requestUrl, client, options)
        {
        }

        /// <summary>
        /// Creates the specified AppConsentApprovalRoute using POST.
        /// </summary>
        /// <param name="appConsentApprovalRouteToCreate">The AppConsentApprovalRoute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AppConsentApprovalRoute.</returns>
        public async System.Threading.Tasks.Task<AppConsentApprovalRoute> CreateAsync(AppConsentApprovalRoute appConsentApprovalRouteToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            var newEntity = await this.SendAsync<AppConsentApprovalRoute>(appConsentApprovalRouteToCreate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(newEntity);
            return newEntity;
        }

        /// <summary>
        /// Creates the specified AppConsentApprovalRoute using POST and returns a <see cref="GraphResponse{AppConsentApprovalRoute}"/> object.
        /// </summary>
        /// <param name="appConsentApprovalRouteToCreate">The AppConsentApprovalRoute to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppConsentApprovalRoute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppConsentApprovalRoute>> CreateResponseAsync(AppConsentApprovalRoute appConsentApprovalRouteToCreate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.POST;
            return this.SendAsyncWithGraphResponse<AppConsentApprovalRoute>(appConsentApprovalRouteToCreate, cancellationToken);
        }

        /// <summary>
        /// Deletes the specified AppConsentApprovalRoute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            await this.SendAsync<AppConsentApprovalRoute>(null, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Deletes the specified AppConsentApprovalRoute and returns a <see cref="GraphResponse"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task of <see cref="GraphResponse"/> to await.</returns>
        public System.Threading.Tasks.Task<GraphResponse> DeleteResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.DELETE;
            return this.SendAsyncWithGraphResponse(null, cancellationToken);
        }

        /// <summary>
        /// Gets the specified AppConsentApprovalRoute.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AppConsentApprovalRoute.</returns>
        public async System.Threading.Tasks.Task<AppConsentApprovalRoute> GetAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            var retrievedEntity = await this.SendAsync<AppConsentApprovalRoute>(null, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(retrievedEntity);
            return retrievedEntity;
        }

        /// <summary>
        /// Gets the specified AppConsentApprovalRoute and returns a <see cref="GraphResponse{AppConsentApprovalRoute}"/> object.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The <see cref="GraphResponse{AppConsentApprovalRoute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppConsentApprovalRoute>> GetResponseAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            this.Method = HttpMethods.GET;
            return this.SendAsyncWithGraphResponse<AppConsentApprovalRoute>(null, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AppConsentApprovalRoute using PATCH.
        /// </summary>
        /// <param name="appConsentApprovalRouteToUpdate">The AppConsentApprovalRoute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AppConsentApprovalRoute.</returns>
        public async System.Threading.Tasks.Task<AppConsentApprovalRoute> UpdateAsync(AppConsentApprovalRoute appConsentApprovalRouteToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            var updatedEntity = await this.SendAsync<AppConsentApprovalRoute>(appConsentApprovalRouteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AppConsentApprovalRoute using PATCH and returns a <see cref="GraphResponse{AppConsentApprovalRoute}"/> object.
        /// </summary>
        /// <param name="appConsentApprovalRouteToUpdate">The AppConsentApprovalRoute to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The <see cref="GraphResponse{AppConsentApprovalRoute}"/> object of the request.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppConsentApprovalRoute>> UpdateResponseAsync(AppConsentApprovalRoute appConsentApprovalRouteToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PATCH;
            return this.SendAsyncWithGraphResponse<AppConsentApprovalRoute>(appConsentApprovalRouteToUpdate, cancellationToken);
        }

        /// <summary>
        /// Updates the specified AppConsentApprovalRoute using PUT.
        /// </summary>
        /// <param name="appConsentApprovalRouteToUpdate">The AppConsentApprovalRoute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        public async System.Threading.Tasks.Task<AppConsentApprovalRoute> PutAsync(AppConsentApprovalRoute appConsentApprovalRouteToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            var updatedEntity = await this.SendAsync<AppConsentApprovalRoute>(appConsentApprovalRouteToUpdate, cancellationToken).ConfigureAwait(false);
            this.InitializeCollectionProperties(updatedEntity);
            return updatedEntity;
        }

        /// <summary>
        /// Updates the specified AppConsentApprovalRoute using PUT and returns a <see cref="GraphResponse{AppConsentApprovalRoute}"/> object.
        /// </summary>
        /// <param name="appConsentApprovalRouteToUpdate">The AppConsentApprovalRoute object to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await of <see cref="GraphResponse{AppConsentApprovalRoute}"/>.</returns>
        public System.Threading.Tasks.Task<GraphResponse<AppConsentApprovalRoute>> PutResponseAsync(AppConsentApprovalRoute appConsentApprovalRouteToUpdate, CancellationToken cancellationToken = default(CancellationToken))
        {
            this.ContentType = CoreConstants.MimeTypeNames.Application.Json;
            this.Method = HttpMethods.PUT;
            return this.SendAsyncWithGraphResponse<AppConsentApprovalRoute>(appConsentApprovalRouteToUpdate, cancellationToken);
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppConsentApprovalRouteRequest Expand(string value)
        {
            this.QueryOptions.Add(new QueryOption("$expand", value));
            return this;
        }

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        public IAppConsentApprovalRouteRequest Expand(Expression<Func<AppConsentApprovalRoute, object>> expandExpression)
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
        public IAppConsentApprovalRouteRequest Select(string value)
        {
            this.QueryOptions.Add(new QueryOption("$select", value));
            return this;
        }

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        public IAppConsentApprovalRouteRequest Select(Expression<Func<AppConsentApprovalRoute, object>> selectExpression)
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
        /// <param name="appConsentApprovalRouteToInitialize">The <see cref="AppConsentApprovalRoute"/> with the collection properties to initialize.</param>
        private void InitializeCollectionProperties(AppConsentApprovalRoute appConsentApprovalRouteToInitialize)
        {

            if (appConsentApprovalRouteToInitialize != null)
            {
                if (appConsentApprovalRouteToInitialize.AppConsentRequests != null && appConsentApprovalRouteToInitialize.AppConsentRequests.CurrentPage != null)
                {
                    appConsentApprovalRouteToInitialize.AppConsentRequests.InitializeNextPageRequest(this.Client, appConsentApprovalRouteToInitialize.AppConsentRequestsNextLink);
                    // Copy the additional data collection to the page itself so that information is not lost
                    appConsentApprovalRouteToInitialize.AppConsentRequests.AdditionalData = appConsentApprovalRouteToInitialize.AdditionalData;
                }

            }


        }
    }
}
