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
    /// The type Image.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<Image>))]
    public partial class Image
    {

        /// <summary>
        /// Gets or sets height.
        /// Optional. Height of the image, in pixels. Read-only.
        /// </summary>
        [JsonPropertyName("height")]
        public Int32? Height { get; set; }
    
        /// <summary>
        /// Gets or sets width.
        /// Optional. Width of the image, in pixels. Read-only.
        /// </summary>
        [JsonPropertyName("width")]
        public Int32? Width { get; set; }
    
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
