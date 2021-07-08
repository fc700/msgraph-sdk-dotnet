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
    /// The enum IdentityUserFlowAttributeInputType.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum IdentityUserFlowAttributeInputType
    {
    
        /// <summary>
        /// Text Box
        /// </summary>
        TextBox = 1,
	
        /// <summary>
        /// Date Time Dropdown
        /// </summary>
        DateTimeDropdown = 2,
	
        /// <summary>
        /// Radio Single Select
        /// </summary>
        RadioSingleSelect = 3,
	
        /// <summary>
        /// Dropdown Single Select
        /// </summary>
        DropdownSingleSelect = 4,
	
        /// <summary>
        /// Email Box
        /// </summary>
        EmailBox = 5,
	
        /// <summary>
        /// Checkbox Multi Select
        /// </summary>
        CheckboxMultiSelect = 6,
	
    }
}
