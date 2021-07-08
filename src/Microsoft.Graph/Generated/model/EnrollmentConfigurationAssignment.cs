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
    /// The type Enrollment Configuration Assignment.
    /// </summary>
    public partial class EnrollmentConfigurationAssignment : Entity
    {
    
        /// <summary>
        /// Gets or sets target.
        /// Represents an assignment to managed devices in the tenant
        /// </summary>
        [JsonPropertyName("target")]
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
    
    }
}

