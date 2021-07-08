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
    /// The type WorkbookFunctionsDollarDeRequestBuilder.
    /// </summary>
    public partial class WorkbookFunctionsDollarDeRequestBuilder : BaseActionMethodRequestBuilder<IWorkbookFunctionsDollarDeRequest>, IWorkbookFunctionsDollarDeRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="WorkbookFunctionsDollarDeRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="fractionalDollar">A fractionalDollar parameter for the OData method call.</param>
        /// <param name="fraction">A fraction parameter for the OData method call.</param>
        public WorkbookFunctionsDollarDeRequestBuilder(
            string requestUrl,
            IBaseClient client,
            System.Text.Json.JsonDocument fractionalDollar,
            System.Text.Json.JsonDocument fraction)
            : base(requestUrl, client)
        {
            this.SetParameter("fractionalDollar", fractionalDollar, true);
            this.SetParameter("fraction", fraction, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IWorkbookFunctionsDollarDeRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new WorkbookFunctionsDollarDeRequest(functionUrl, this.Client, options);

            if (this.HasParameter("fractionalDollar"))
            {
                request.RequestBody.FractionalDollar = this.GetParameter<System.Text.Json.JsonDocument>("fractionalDollar");
            }

            if (this.HasParameter("fraction"))
            {
                request.RequestBody.Fraction = this.GetParameter<System.Text.Json.JsonDocument>("fraction");
            }

            return request;
        }
    }
}
