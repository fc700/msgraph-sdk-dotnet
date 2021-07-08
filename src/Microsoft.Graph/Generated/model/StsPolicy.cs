// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text.Json.Serialization;

    /// <summary>
    /// The type Sts Policy.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<StsPolicy>))]
    public partial class StsPolicy : PolicyBase
    {
    
        ///<summary>
        /// The internal StsPolicy constructor
        ///</summary>
        protected internal StsPolicy()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets definition.
        /// A string collection containing a JSON string that defines the rules and settings for a policy. The syntax for the definition differs for each derived policy type. Required.
        /// </summary>
        [JsonPropertyName("definition")]
        public IEnumerable<string> Definition { get; set; }
    
        /// <summary>
        /// Gets or sets is organization default.
        /// If set to true, activates this policy. There can be many policies for the same policy type, but only one can be activated as the organization default. Optional, default value is false.
        /// </summary>
        [JsonPropertyName("isOrganizationDefault")]
        public bool? IsOrganizationDefault { get; set; }
    
        /// <summary>
        /// Gets or sets applies to.
        /// </summary>
        [JsonPropertyName("appliesTo")]
        public IStsPolicyAppliesToCollectionWithReferencesPage AppliesTo { get; set; }

        /// <summary>
        /// Gets or sets appliesToNextLink.
        /// </summary>
        [JsonPropertyName("appliesTo@odata.nextLink")]
        public string AppliesToNextLink { get; set; }
    
    }
}

