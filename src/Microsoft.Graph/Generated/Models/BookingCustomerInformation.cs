using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class BookingCustomerInformation : BookingCustomerInformationBase, IParsable {
        /// <summary>The ID of the bookingCustomer for this appointment. If no ID is specified when an appointment is created, then a new bookingCustomer object is created. Once set, you should consider the customerId immutable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerId {
            get { return BackingStore?.Get<string?>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#nullable restore
#else
        public string CustomerId {
            get { return BackingStore?.Get<string>("customerId"); }
            set { BackingStore?.Set("customerId", value); }
        }
#endif
        /// <summary>It consists of the list of custom questions and answers given by the customer as part of the appointment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<BookingQuestionAnswer>? CustomQuestionAnswers {
            get { return BackingStore?.Get<List<BookingQuestionAnswer>?>("customQuestionAnswers"); }
            set { BackingStore?.Set("customQuestionAnswers", value); }
        }
#nullable restore
#else
        public List<BookingQuestionAnswer> CustomQuestionAnswers {
            get { return BackingStore?.Get<List<BookingQuestionAnswer>>("customQuestionAnswers"); }
            set { BackingStore?.Set("customQuestionAnswers", value); }
        }
#endif
        /// <summary>The SMTP address of the bookingCustomer who is booking the appointment</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Represents location information for the bookingCustomer who is booking the appointment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Location? Location {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Location?>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Location Location {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Location>("location"); }
            set { BackingStore?.Set("location", value); }
        }
#endif
        /// <summary>The customer&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>Notes from the customer associated with this appointment. You can get the value only when reading this bookingAppointment by its ID. You can set this property only when initially creating an appointment with a new customer. After that point, the value is computed from the customer represented by the customerId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes {
            get { return BackingStore?.Get<string?>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#nullable restore
#else
        public string Notes {
            get { return BackingStore?.Get<string>("notes"); }
            set { BackingStore?.Set("notes", value); }
        }
#endif
        /// <summary>The customer&apos;s phone number.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Phone {
            get { return BackingStore?.Get<string?>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#nullable restore
#else
        public string Phone {
            get { return BackingStore?.Get<string>("phone"); }
            set { BackingStore?.Set("phone", value); }
        }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeZone {
            get { return BackingStore?.Get<string?>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#nullable restore
#else
        public string TimeZone {
            get { return BackingStore?.Get<string>("timeZone"); }
            set { BackingStore?.Set("timeZone", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new bookingCustomerInformation and sets the default values.
        /// </summary>
        public BookingCustomerInformation() : base() {
            OdataType = "#microsoft.graph.bookingCustomerInformation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new BookingCustomerInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingCustomerInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customerId", n => { CustomerId = n.GetStringValue(); } },
                {"customQuestionAnswers", n => { CustomQuestionAnswers = n.GetCollectionOfObjectValues<BookingQuestionAnswer>(BookingQuestionAnswer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"location", n => { Location = n.GetObjectValue<Microsoft.Graph.Models.Location>(Microsoft.Graph.Models.Location.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"phone", n => { Phone = n.GetStringValue(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("customerId", CustomerId);
            writer.WriteCollectionOfObjectValues<BookingQuestionAnswer>("customQuestionAnswers", CustomQuestionAnswers);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<Microsoft.Graph.Models.Location>("location", Location);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("notes", Notes);
            writer.WriteStringValue("phone", Phone);
            writer.WriteStringValue("timeZone", TimeZone);
        }
    }
}
