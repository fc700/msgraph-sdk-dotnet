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
    /// The type DeviceManagementSettings.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DeviceManagementSettings>))]
    public partial class DeviceManagementSettings
    {

        /// <summary>
        /// Gets or sets deviceComplianceCheckinThresholdDays.
        /// The number of days a device is allowed to go without checking in to remain compliant.
        /// </summary>
        [JsonPropertyName("deviceComplianceCheckinThresholdDays")]
        public Int32? DeviceComplianceCheckinThresholdDays { get; set; }
    
        /// <summary>
        /// Gets or sets isScheduledActionEnabled.
        /// Is feature enabled or not for scheduled action for rule.
        /// </summary>
        [JsonPropertyName("isScheduledActionEnabled")]
        public bool? IsScheduledActionEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets secureByDefault.
        /// Device should be noncompliant when there is no compliance policy targeted when this is true
        /// </summary>
        [JsonPropertyName("secureByDefault")]
        public bool? SecureByDefault { get; set; }
    
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
