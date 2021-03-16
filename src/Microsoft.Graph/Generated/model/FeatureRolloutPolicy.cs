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
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Feature Rollout Policy.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class FeatureRolloutPolicy : Entity
    {
    
		///<summary>
		/// The FeatureRolloutPolicy constructor
		///</summary>
        public FeatureRolloutPolicy()
        {
            this.ODataType = "microsoft.graph.featureRolloutPolicy";
        }
	
        /// <summary>
        /// Gets or sets description.
        /// A description for this feature rollout policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "description", Required = Newtonsoft.Json.Required.Default)]
        public string Description { get; set; }
    
        /// <summary>
        /// Gets or sets display name.
        /// The display name for this  feature rollout policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "displayName", Required = Newtonsoft.Json.Required.Default)]
        public string DisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets feature.
        /// Possible values are: passthroughAuthentication, seamlessSso, passwordHashSync, unknownFutureValue.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "feature", Required = Newtonsoft.Json.Required.Default)]
        public StagedFeatureName? Feature { get; set; }
    
        /// <summary>
        /// Gets or sets is applied to organization.
        /// Indicates whether this feature rollout policy should be applied to the entire organization.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isAppliedToOrganization", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsAppliedToOrganization { get; set; }
    
        /// <summary>
        /// Gets or sets is enabled.
        /// Indicates whether the feature rollout is enabled.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isEnabled", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets applies to.
        /// Nullable. Specifies a list of directoryObjects that feature is enabled for.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appliesTo", Required = Newtonsoft.Json.Required.Default)]
        public IFeatureRolloutPolicyAppliesToCollectionPage AppliesTo { get; set; }
    
    }
}

