// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    [Flags]
    public enum MailTipsType {
        [EnumMember(Value = "automaticReplies")]
        AutomaticReplies = 1,
        [EnumMember(Value = "mailboxFullStatus")]
        MailboxFullStatus = 2,
        [EnumMember(Value = "customMailTip")]
        CustomMailTip = 4,
        [EnumMember(Value = "externalMemberCount")]
        ExternalMemberCount = 8,
        [EnumMember(Value = "totalMemberCount")]
        TotalMemberCount = 16,
        [EnumMember(Value = "maxMessageSize")]
        MaxMessageSize = 32,
        [EnumMember(Value = "deliveryRestriction")]
        DeliveryRestriction = 64,
        [EnumMember(Value = "moderationStatus")]
        ModerationStatus = 128,
        [EnumMember(Value = "recipientScope")]
        RecipientScope = 256,
        [EnumMember(Value = "recipientSuggestions")]
        RecipientSuggestions = 512,
    }
}
