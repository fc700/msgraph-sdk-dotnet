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
    /// The enum CallState.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CallState
    {
    
        /// <summary>
        /// Incoming
        /// </summary>
        Incoming = 0,
	
        /// <summary>
        /// Establishing
        /// </summary>
        Establishing = 1,
	
        /// <summary>
        /// Established
        /// </summary>
        Established = 3,
	
        /// <summary>
        /// Hold
        /// </summary>
        Hold = 4,
	
        /// <summary>
        /// Transferring
        /// </summary>
        Transferring = 5,
	
        /// <summary>
        /// Transfer Accepted
        /// </summary>
        TransferAccepted = 6,
	
        /// <summary>
        /// Redirecting
        /// </summary>
        Redirecting = 7,
	
        /// <summary>
        /// Terminating
        /// </summary>
        Terminating = 8,
	
        /// <summary>
        /// Terminated
        /// </summary>
        Terminated = 9,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 10,
	
    }
}
