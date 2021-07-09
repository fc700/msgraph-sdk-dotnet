﻿// ------------------------------------------------------------------------------
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
    /// The type Policy Root.
    /// </summary>
    public partial class PolicyRoot : Entity
    {
    
        /// <summary>
        /// Gets or sets authentication methods policy.
        /// </summary>
        [JsonPropertyName("authenticationMethodsPolicy")]
        public AuthenticationMethodsPolicy AuthenticationMethodsPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets authentication flows policy.
        /// </summary>
        [JsonPropertyName("authenticationFlowsPolicy")]
        public AuthenticationFlowsPolicy AuthenticationFlowsPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets activity based timeout policies.
        /// </summary>
        [JsonPropertyName("activityBasedTimeoutPolicies")]
        public IPolicyRootActivityBasedTimeoutPoliciesCollectionPage ActivityBasedTimeoutPolicies { get; set; }

        /// <summary>
        /// Gets or sets activityBasedTimeoutPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("activityBasedTimeoutPolicies@odata.nextLink")]
        public string ActivityBasedTimeoutPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets authorization policy.
        /// </summary>
        [JsonPropertyName("authorizationPolicy")]
        public AuthorizationPolicy AuthorizationPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets claims mapping policies.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies")]
        public IPolicyRootClaimsMappingPoliciesCollectionPage ClaimsMappingPolicies { get; set; }

        /// <summary>
        /// Gets or sets claimsMappingPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("claimsMappingPolicies@odata.nextLink")]
        public string ClaimsMappingPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets home realm discovery policies.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies")]
        public IPolicyRootHomeRealmDiscoveryPoliciesCollectionPage HomeRealmDiscoveryPolicies { get; set; }

        /// <summary>
        /// Gets or sets homeRealmDiscoveryPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("homeRealmDiscoveryPolicies@odata.nextLink")]
        public string HomeRealmDiscoveryPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets permission grant policies.
        /// </summary>
        [JsonPropertyName("permissionGrantPolicies")]
        public IPolicyRootPermissionGrantPoliciesCollectionPage PermissionGrantPolicies { get; set; }

        /// <summary>
        /// Gets or sets permissionGrantPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("permissionGrantPolicies@odata.nextLink")]
        public string PermissionGrantPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token issuance policies.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies")]
        public IPolicyRootTokenIssuancePoliciesCollectionPage TokenIssuancePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenIssuancePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenIssuancePolicies@odata.nextLink")]
        public string TokenIssuancePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets token lifetime policies.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies")]
        public IPolicyRootTokenLifetimePoliciesCollectionPage TokenLifetimePolicies { get; set; }

        /// <summary>
        /// Gets or sets tokenLifetimePoliciesNextLink.
        /// </summary>
        [JsonPropertyName("tokenLifetimePolicies@odata.nextLink")]
        public string TokenLifetimePoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets feature rollout policies.
        /// </summary>
        [JsonPropertyName("featureRolloutPolicies")]
        public IPolicyRootFeatureRolloutPoliciesCollectionPage FeatureRolloutPolicies { get; set; }

        /// <summary>
        /// Gets or sets featureRolloutPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("featureRolloutPolicies@odata.nextLink")]
        public string FeatureRolloutPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets admin consent request policy.
        /// </summary>
        [JsonPropertyName("adminConsentRequestPolicy")]
        public AdminConsentRequestPolicy AdminConsentRequestPolicy { get; set; }
    
        /// <summary>
        /// Gets or sets conditional access policies.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicies")]
        public IPolicyRootConditionalAccessPoliciesCollectionPage ConditionalAccessPolicies { get; set; }

        /// <summary>
        /// Gets or sets conditionalAccessPoliciesNextLink.
        /// </summary>
        [JsonPropertyName("conditionalAccessPolicies@odata.nextLink")]
        public string ConditionalAccessPoliciesNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets identity security defaults enforcement policy.
        /// </summary>
        [JsonPropertyName("identitySecurityDefaultsEnforcementPolicy")]
        public IdentitySecurityDefaultsEnforcementPolicy IdentitySecurityDefaultsEnforcementPolicy { get; set; }
    
    }
}

