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
    /// The type Organizational Branding Properties.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<OrganizationalBrandingProperties>))]
    public partial class OrganizationalBrandingProperties : Entity
    {
    
        ///<summary>
        /// The internal OrganizationalBrandingProperties constructor
        ///</summary>
        protected internal OrganizationalBrandingProperties()
        {
            // Don't allow initialization of abstract entity types
        }
    
        /// <summary>
        /// Gets or sets background color.
        /// Color that will appear in place of the background image in low-bandwidth connections. The primary color of your banner logo or your organization color is recommended to be used here. Specify this in hexadecimal (for example, white is #FFFFFF).
        /// </summary>
        [JsonPropertyName("backgroundColor")]
        public string BackgroundColor { get; set; }
    
        /// <summary>
        /// Gets or sets background image.
        /// Image that appears as the background of the sign in page. .png or .jpg not larger than 1920x1080 and smaller than 300kb. A smaller image will reduce bandwidth requirements and make page loads more performant.
        /// </summary>
        [JsonPropertyName("backgroundImage")]
        public Stream BackgroundImage { get; set; }
    
        /// <summary>
        /// Gets or sets banner logo.
        /// A banner version of your company logo which appears appears on the sign-in page. .png or .jpg no larger than 36x245px. We recommend using a transparent image with no padding around the logo.
        /// </summary>
        [JsonPropertyName("bannerLogo")]
        public Stream BannerLogo { get; set; }
    
        /// <summary>
        /// Gets or sets sign in page text.
        /// Text that appears at the bottom of the sign-in box. You can use this to communicate additional information, such as the phone number to your help desk or a legal statement. This text must be Unicode and not exceed 1024 characters.
        /// </summary>
        [JsonPropertyName("signInPageText")]
        public string SignInPageText { get; set; }
    
        /// <summary>
        /// Gets or sets square logo.
        /// Square version of your company logo. This appears in Windows 10 out-of-box (OOBE) experiences and when Windows Autopilot is enabled for deployment. .png or .jpg no larger than 240x240px and no more than 10kb in size. We recommend using a transparent image with no padding around the logo.
        /// </summary>
        [JsonPropertyName("squareLogo")]
        public Stream SquareLogo { get; set; }
    
        /// <summary>
        /// Gets or sets username hint text.
        /// String that shows as the hint in the username textbox on the sign in screen. This text must be Unicode, without links or code, and can't exceed 64 characters.
        /// </summary>
        [JsonPropertyName("usernameHintText")]
        public string UsernameHintText { get; set; }
    
    }
}

