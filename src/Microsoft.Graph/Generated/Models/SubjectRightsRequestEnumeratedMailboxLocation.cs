// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SubjectRightsRequestEnumeratedMailboxLocation : SubjectRightsRequestMailboxLocation, IParsable {
        /// <summary>The userPrincipalNames property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UserPrincipalNames {
            get { return BackingStore?.Get<List<string>?>("userPrincipalNames"); }
            set { BackingStore?.Set("userPrincipalNames", value); }
        }
#nullable restore
#else
        public List<string> UserPrincipalNames {
            get { return BackingStore?.Get<List<string>>("userPrincipalNames"); }
            set { BackingStore?.Set("userPrincipalNames", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new subjectRightsRequestEnumeratedMailboxLocation and sets the default values.
        /// </summary>
        public SubjectRightsRequestEnumeratedMailboxLocation() : base() {
            OdataType = "#microsoft.graph.subjectRightsRequestEnumeratedMailboxLocation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SubjectRightsRequestEnumeratedMailboxLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SubjectRightsRequestEnumeratedMailboxLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userPrincipalNames", n => { UserPrincipalNames = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("userPrincipalNames", UserPrincipalNames);
        }
    }
}
