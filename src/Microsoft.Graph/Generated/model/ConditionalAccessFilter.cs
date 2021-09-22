// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type ConditionalAccessFilter.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<ConditionalAccessFilter>))]
    public partial class ConditionalAccessFilter
    {

        /// <summary>
        /// Gets or sets mode.
        /// Mode to use for the filter. Possible values are include or exclude.
        /// </summary>
        [JsonPropertyName("mode")]
        public FilterMode? Mode { get; set; }
    
        /// <summary>
        /// Gets or sets rule.
        /// Rule syntax is similar to that used for membership rules for groups in Azure AD. For details, see rules with multiple expressions
        /// </summary>
        [JsonPropertyName("rule")]
        public string Rule { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonPropertyName("@odata.type")]
        public string ODataType { get; set; }
    
    }
}
