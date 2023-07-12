using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    /// <summary>
    /// Contains properties and inherited properties for the macOS Microsoft Edge App.
    /// </summary>
    public class MacOSMicrosoftEdgeApp : MobileApp, IParsable {
        /// <summary>The enum to specify the channels for Microsoft Edge apps.</summary>
        public MicrosoftEdgeChannel? Channel {
            get { return BackingStore?.Get<MicrosoftEdgeChannel?>("channel"); }
            set { BackingStore?.Set("channel", value); }
        }
        /// <summary>
        /// Instantiates a new macOSMicrosoftEdgeApp and sets the default values.
        /// </summary>
        public MacOSMicrosoftEdgeApp() : base() {
            OdataType = "#microsoft.graph.macOSMicrosoftEdgeApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MacOSMicrosoftEdgeApp CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSMicrosoftEdgeApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channel", n => { Channel = n.GetEnumValue<MicrosoftEdgeChannel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MicrosoftEdgeChannel>("channel", Channel);
        }
    }
}
