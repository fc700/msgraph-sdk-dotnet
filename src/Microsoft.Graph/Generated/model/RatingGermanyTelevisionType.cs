// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: EnumType.cs.tt


namespace Microsoft.Graph
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// The enum RatingGermanyTelevisionType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RatingGermanyTelevisionType
    {
    
        /// <summary>
        /// All Allowed
        /// </summary>
        AllAllowed = 0,
	
        /// <summary>
        /// All Blocked
        /// </summary>
        AllBlocked = 1,
	
        /// <summary>
        /// General
        /// </summary>
        General = 2,
	
        /// <summary>
        /// Ages Above6
        /// </summary>
        AgesAbove6 = 3,
	
        /// <summary>
        /// Ages Above12
        /// </summary>
        AgesAbove12 = 4,
	
        /// <summary>
        /// Ages Above16
        /// </summary>
        AgesAbove16 = 5,
	
        /// <summary>
        /// Adults
        /// </summary>
        Adults = 6,
	
    }
}
