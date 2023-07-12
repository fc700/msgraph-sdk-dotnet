using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class UserSource : DataSource, IParsable {
        /// <summary>Email address of the user&apos;s mailbox.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Email {
            get { return BackingStore?.Get<string?>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#nullable restore
#else
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
#endif
        /// <summary>Specifies which sources are included in this group. Possible values are: mailbox, site.</summary>
        public SourceType? IncludedSources {
            get { return BackingStore?.Get<SourceType?>("includedSources"); }
            set { BackingStore?.Set("includedSources", value); }
        }
        /// <summary>The URL of the user&apos;s OneDrive for Business site. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteWebUrl {
            get { return BackingStore?.Get<string?>("siteWebUrl"); }
            set { BackingStore?.Set("siteWebUrl", value); }
        }
#nullable restore
#else
        public string SiteWebUrl {
            get { return BackingStore?.Get<string>("siteWebUrl"); }
            set { BackingStore?.Set("siteWebUrl", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new userSource and sets the default values.
        /// </summary>
        public UserSource() : base() {
            OdataType = "#microsoft.graph.security.userSource";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserSource CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserSource();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"email", n => { Email = n.GetStringValue(); } },
                {"includedSources", n => { IncludedSources = n.GetEnumValue<SourceType>(); } },
                {"siteWebUrl", n => { SiteWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("email", Email);
            writer.WriteEnumValue<SourceType>("includedSources", IncludedSources);
            writer.WriteStringValue("siteWebUrl", SiteWebUrl);
        }
    }
}
