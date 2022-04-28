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
    /// The type TeamworkOnlineMeetingInfo.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<TeamworkOnlineMeetingInfo>))]
    public partial class TeamworkOnlineMeetingInfo
    {

        /// <summary>
        /// Gets or sets calendarEventId.
        /// The identifier of the calendar event associated with the meeting.
        /// </summary>
        [JsonPropertyName("calendarEventId")]
        public string CalendarEventId { get; set; }
    
        /// <summary>
        /// Gets or sets joinWebUrl.
        /// The URL which can be clicked on to join or uniquely identify the meeting.
        /// </summary>
        [JsonPropertyName("joinWebUrl")]
        public string JoinWebUrl { get; set; }
    
        /// <summary>
        /// Gets or sets organizer.
        /// The organizer of the meeting.
        /// </summary>
        [JsonPropertyName("organizer")]
        public TeamworkUserIdentity Organizer { get; set; }
    
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
