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
    /// The enum MediaDirection.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MediaDirection
    {
    
        /// <summary>
        /// Inactive
        /// </summary>
        Inactive = 0,
	
        /// <summary>
        /// Send Only
        /// </summary>
        SendOnly = 1,
	
        /// <summary>
        /// Receive Only
        /// </summary>
        ReceiveOnly = 2,
	
        /// <summary>
        /// Send Receive
        /// </summary>
        SendReceive = 3,
	
    }
}
