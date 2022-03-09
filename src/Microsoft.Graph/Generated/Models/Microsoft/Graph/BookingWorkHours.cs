using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the solutionsRoot singleton.</summary>
    public class BookingWorkHours : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The day of the week represented by this instance. Possible values are: sunday, monday, tuesday, wednesday, thursday, friday, saturday.</summary>
        public DayOfWeek? Day { get; set; }
        /// <summary>A list of start/end times during a day.</summary>
        public List<BookingWorkTimeSlot> TimeSlots { get; set; }
        /// <summary>
        /// Instantiates a new bookingWorkHours and sets the default values.
        /// </summary>
        public BookingWorkHours() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static BookingWorkHours CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingWorkHours();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"day", (o,n) => { (o as BookingWorkHours).Day = n.GetEnumValue<DayOfWeek>(); } },
                {"timeSlots", (o,n) => { (o as BookingWorkHours).TimeSlots = n.GetCollectionOfObjectValues<BookingWorkTimeSlot>(BookingWorkTimeSlot.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DayOfWeek>("day", Day);
            writer.WriteCollectionOfObjectValues<BookingWorkTimeSlot>("timeSlots", TimeSlots);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
