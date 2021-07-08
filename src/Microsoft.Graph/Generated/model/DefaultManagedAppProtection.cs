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
    /// The type Default Managed App Protection.
    /// </summary>
    [JsonConverter(typeof(DerivedTypeConverter<DefaultManagedAppProtection>))]
    public partial class DefaultManagedAppProtection : ManagedAppProtection
    {
    
        ///<summary>
        /// The DefaultManagedAppProtection constructor
        ///</summary>
        public DefaultManagedAppProtection()
        {
            this.ODataType = "microsoft.graph.defaultManagedAppProtection";
        }

        /// <summary>
        /// Gets or sets app data encryption type.
        /// Type of encryption which should be used for data in a managed app. (iOS Only). Possible values are: useDeviceSettings, afterDeviceRestart, whenDeviceLockedExceptOpenFiles, whenDeviceLocked.
        /// </summary>
        [JsonPropertyName("appDataEncryptionType")]
        public ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }
    
        /// <summary>
        /// Gets or sets custom settings.
        /// A set of string key and string value pairs to be sent to the affected users, unalterned by this service
        /// </summary>
        [JsonPropertyName("customSettings")]
        public IEnumerable<KeyValuePair> CustomSettings { get; set; }
    
        /// <summary>
        /// Gets or sets deployed app count.
        /// Count of apps to which the current policy is deployed.
        /// </summary>
        [JsonPropertyName("deployedAppCount")]
        public Int32? DeployedAppCount { get; set; }
    
        /// <summary>
        /// Gets or sets disable app encryption if device encryption is enabled.
        /// When this setting is enabled, app level encryption is disabled if device level encryption is enabled. (Android only)
        /// </summary>
        [JsonPropertyName("disableAppEncryptionIfDeviceEncryptionIsEnabled")]
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }
    
        /// <summary>
        /// Gets or sets encrypt app data.
        /// Indicates whether managed-app data should be encrypted. (Android only)
        /// </summary>
        [JsonPropertyName("encryptAppData")]
        public bool? EncryptAppData { get; set; }
    
        /// <summary>
        /// Gets or sets face id blocked.
        /// Indicates whether use of the FaceID is allowed in place of a pin if PinRequired is set to True. (iOS Only)
        /// </summary>
        [JsonPropertyName("faceIdBlocked")]
        public bool? FaceIdBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required patch version.
        /// Define the oldest required Android security patch level a user can have to gain secure access to the app. (Android only)
        /// </summary>
        [JsonPropertyName("minimumRequiredPatchVersion")]
        public string MinimumRequiredPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum required sdk version.
        /// Versions less than the specified version will block the managed app from accessing company data. (iOS Only)
        /// </summary>
        [JsonPropertyName("minimumRequiredSdkVersion")]
        public string MinimumRequiredSdkVersion { get; set; }
    
        /// <summary>
        /// Gets or sets minimum warning patch version.
        /// Define the oldest recommended Android security patch level a user can have for secure access to the app. (Android only)
        /// </summary>
        [JsonPropertyName("minimumWarningPatchVersion")]
        public string MinimumWarningPatchVersion { get; set; }
    
        /// <summary>
        /// Gets or sets screen capture blocked.
        /// Indicates whether screen capture is blocked. (Android only)
        /// </summary>
        [JsonPropertyName("screenCaptureBlocked")]
        public bool? ScreenCaptureBlocked { get; set; }
    
        /// <summary>
        /// Gets or sets apps.
        /// List of apps to which the policy is deployed.
        /// </summary>
        [JsonPropertyName("apps")]
        public IDefaultManagedAppProtectionAppsCollectionPage Apps { get; set; }

        /// <summary>
        /// Gets or sets appsNextLink.
        /// </summary>
        [JsonPropertyName("apps@odata.nextLink")]
        public string AppsNextLink { get; set; }
    
        /// <summary>
        /// Gets or sets deployment summary.
        /// Navigation property to deployment summary of the configuration.
        /// </summary>
        [JsonPropertyName("deploymentSummary")]
        public ManagedAppPolicyDeploymentSummary DeploymentSummary { get; set; }
    
    }
}

