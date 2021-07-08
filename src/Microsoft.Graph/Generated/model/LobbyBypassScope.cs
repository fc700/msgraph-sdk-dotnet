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
    /// The enum LobbyBypassScope.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum LobbyBypassScope
    {
    
        /// <summary>
        /// Organizer
        /// </summary>
        Organizer = 0,
	
        /// <summary>
        /// Organization
        /// </summary>
        Organization = 1,
	
        /// <summary>
        /// Organization And Federated
        /// </summary>
        OrganizationAndFederated = 2,
	
        /// <summary>
        /// Everyone
        /// </summary>
        Everyone = 3,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 4,
	
    }
}
