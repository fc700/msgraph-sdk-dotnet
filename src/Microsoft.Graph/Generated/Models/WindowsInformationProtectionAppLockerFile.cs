using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    /// <summary>Windows Information Protection AppLocker File</summary>
    public class WindowsInformationProtectionAppLockerFile : Entity, IParsable {
        /// <summary>The friendly name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>File as a byte array</summary>
        public byte[] File {
            get { return BackingStore?.Get<byte[]>("file"); }
            set { BackingStore?.Set("file", value); }
        }
        /// <summary>SHA256 hash of the file</summary>
        public string FileHash {
            get { return BackingStore?.Get<string>("fileHash"); }
            set { BackingStore?.Set("fileHash", value); }
        }
        /// <summary>Version of the entity.</summary>
        public string Version {
            get { return BackingStore?.Get<string>("version"); }
            set { BackingStore?.Set("version", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsInformationProtectionAppLockerFile CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsInformationProtectionAppLockerFile();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"file", n => { File = n.GetByteArrayValue(); } },
                {"fileHash", n => { FileHash = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteByteArrayValue("file", File);
            writer.WriteStringValue("fileHash", FileHash);
            writer.WriteStringValue("version", Version);
        }
    }
}
