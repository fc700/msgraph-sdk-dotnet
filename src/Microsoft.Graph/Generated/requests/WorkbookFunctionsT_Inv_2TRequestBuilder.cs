// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type WorkbookFunctionsT_Inv_2TRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsT_Inv_2TRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsT_Inv_2TRequest>, IWorkbookFunctionsT_Inv_2TRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsT_Inv_2TRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="probability">A probability parameter for the OData method call.</param>
        /// <param name="degFreedom">A degFreedom parameter for the OData method call.</param>
        public WorkbookFunctionsT_Inv_2TRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument probability,
            System.Text.Json.JsonDocument degFreedom)
            : base(requestUrl, client)
        {
            this.SetParameter("probability", probability, true);
            this.SetParameter("degFreedom", degFreedom, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsT_Inv_2TRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsT_Inv_2TRequest(functionUrl, this.Client, options);

            if (this.HasParameter("probability"))
            {
                request.RequestBody.Probability = this.GetParameter<System.Text.Json.JsonDocument>("probability");
            }

            if (this.HasParameter("degFreedom"))
            {
                request.RequestBody.DegFreedom = this.GetParameter<System.Text.Json.JsonDocument>("degFreedom");
            }

            return request;
        }
    }
}
