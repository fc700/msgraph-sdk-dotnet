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
    /// The type Workbook Chart Data Labels.
    /// </summary>
    public partial class WorkbookChartDataLabels : Entity
    {
    
        /// <summary>
        /// Gets or sets position.
        /// DataLabelPosition value that represents the position of the data label. The possible values are: None, Center, InsideEnd, InsideBase, OutsideEnd, Left, Right, Top, Bottom, BestFit, Callout.
        /// </summary>
        [JsonPropertyName("position")]
        public string Position { get; set; }
    
        /// <summary>
        /// Gets or sets separator.
        /// String representing the separator used for the data labels on a chart.
        /// </summary>
        [JsonPropertyName("separator")]
        public string Separator { get; set; }
    
        /// <summary>
        /// Gets or sets show bubble size.
        /// Boolean value representing if the data label bubble size is visible or not.
        /// </summary>
        [JsonPropertyName("showBubbleSize")]
        public bool? ShowBubbleSize { get; set; }
    
        /// <summary>
        /// Gets or sets show category name.
        /// Boolean value representing if the data label category name is visible or not.
        /// </summary>
        [JsonPropertyName("showCategoryName")]
        public bool? ShowCategoryName { get; set; }
    
        /// <summary>
        /// Gets or sets show legend key.
        /// Boolean value representing if the data label legend key is visible or not.
        /// </summary>
        [JsonPropertyName("showLegendKey")]
        public bool? ShowLegendKey { get; set; }
    
        /// <summary>
        /// Gets or sets show percentage.
        /// Boolean value representing if the data label percentage is visible or not.
        /// </summary>
        [JsonPropertyName("showPercentage")]
        public bool? ShowPercentage { get; set; }
    
        /// <summary>
        /// Gets or sets show series name.
        /// Boolean value representing if the data label series name is visible or not.
        /// </summary>
        [JsonPropertyName("showSeriesName")]
        public bool? ShowSeriesName { get; set; }
    
        /// <summary>
        /// Gets or sets show value.
        /// Boolean value representing if the data label value is visible or not.
        /// </summary>
        [JsonPropertyName("showValue")]
        public bool? ShowValue { get; set; }
    
        /// <summary>
        /// Gets or sets format.
        /// Represents the format of chart data labels, which includes fill and font formatting. Read-only.
        /// </summary>
        [JsonPropertyName("format")]
        public WorkbookChartDataLabelFormat Format { get; set; }
    
    }
}

