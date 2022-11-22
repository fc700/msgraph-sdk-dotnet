using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class ChatMessageInfo : Entity, IParsable {
        /// <summary>Body of the chatMessage. This will still contain markers for @mentions and attachments even though the object does not return @mentions and attachments.</summary>
        public ItemBody Body {
            get { return BackingStore?.Get<ItemBody>("body"); }
            set { BackingStore?.Set("body", value); }
        }
        /// <summary>Date time object representing the time at which message was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Read-only.  If present, represents details of an event that happened in a chat, a channel, or a team, for example, members were added, and so on. For event messages, the messageType property will be set to systemEventMessage.</summary>
        public EventMessageDetail EventDetail {
            get { return BackingStore?.Get<EventMessageDetail>("eventDetail"); }
            set { BackingStore?.Set("eventDetail", value); }
        }
        /// <summary>Information about the sender of the message.</summary>
        public ChatMessageFromIdentitySet From {
            get { return BackingStore?.Get<ChatMessageFromIdentitySet>("from"); }
            set { BackingStore?.Set("from", value); }
        }
        /// <summary>If set to true, the original message has been deleted.</summary>
        public bool? IsDeleted {
            get { return BackingStore?.Get<bool?>("isDeleted"); }
            set { BackingStore?.Set("isDeleted", value); }
        }
        /// <summary>The messageType property</summary>
        public ChatMessageType? MessageType {
            get { return BackingStore?.Get<ChatMessageType?>("messageType"); }
            set { BackingStore?.Set("messageType", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ChatMessageInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChatMessageInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"body", n => { Body = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"eventDetail", n => { EventDetail = n.GetObjectValue<EventMessageDetail>(EventMessageDetail.CreateFromDiscriminatorValue); } },
                {"from", n => { From = n.GetObjectValue<ChatMessageFromIdentitySet>(ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"messageType", n => { MessageType = n.GetEnumValue<ChatMessageType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemBody>("body", Body);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<ChatMessageFromIdentitySet>("from", From);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteEnumValue<ChatMessageType>("messageType", MessageType);
        }
    }
}
