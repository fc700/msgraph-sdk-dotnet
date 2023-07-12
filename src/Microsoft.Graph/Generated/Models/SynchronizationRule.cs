using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class SynchronizationRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The containerFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ContainerFilter? ContainerFilter {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ContainerFilter?>("containerFilter"); }
            set { BackingStore?.Set("containerFilter", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ContainerFilter ContainerFilter {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ContainerFilter>("containerFilter"); }
            set { BackingStore?.Set("containerFilter", value); }
        }
#endif
        /// <summary>true if the synchronization rule can be customized; false if this rule is read-only and should not be changed.</summary>
        public bool? Editable {
            get { return BackingStore?.Get<bool?>("editable"); }
            set { BackingStore?.Set("editable", value); }
        }
        /// <summary>The groupFilter property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.GroupFilter? GroupFilter {
            get { return BackingStore?.Get<Microsoft.Graph.Models.GroupFilter?>("groupFilter"); }
            set { BackingStore?.Set("groupFilter", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.GroupFilter GroupFilter {
            get { return BackingStore?.Get<Microsoft.Graph.Models.GroupFilter>("groupFilter"); }
            set { BackingStore?.Set("groupFilter", value); }
        }
#endif
        /// <summary>Synchronization rule identifier. Must be one of the identifiers recognized by the synchronization engine. Supported rule identifiers can be found in the synchronization template returned by the API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id {
            get { return BackingStore?.Get<string?>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#nullable restore
#else
        public string Id {
            get { return BackingStore?.Get<string>("id"); }
            set { BackingStore?.Set("id", value); }
        }
#endif
        /// <summary>Additional extension properties. Unless instructed explicitly by the support team, metadata values should not be changed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StringKeyStringValuePair>? Metadata {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>?>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#nullable restore
#else
        public List<StringKeyStringValuePair> Metadata {
            get { return BackingStore?.Get<List<StringKeyStringValuePair>>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
#endif
        /// <summary>Human-readable name of the synchronization rule. Not nullable.</summary>
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
        /// <summary>Collection of object mappings supported by the rule. Tells the synchronization engine which objects should be synchronized.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ObjectMapping>? ObjectMappings {
            get { return BackingStore?.Get<List<ObjectMapping>?>("objectMappings"); }
            set { BackingStore?.Set("objectMappings", value); }
        }
#nullable restore
#else
        public List<ObjectMapping> ObjectMappings {
            get { return BackingStore?.Get<List<ObjectMapping>>("objectMappings"); }
            set { BackingStore?.Set("objectMappings", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Priority relative to other rules in the synchronizationSchema. Rules with the lowest priority number will be processed first.</summary>
        public int? Priority {
            get { return BackingStore?.Get<int?>("priority"); }
            set { BackingStore?.Set("priority", value); }
        }
        /// <summary>Name of the source directory. Must match one of the directory definitions in synchronizationSchema.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceDirectoryName {
            get { return BackingStore?.Get<string?>("sourceDirectoryName"); }
            set { BackingStore?.Set("sourceDirectoryName", value); }
        }
#nullable restore
#else
        public string SourceDirectoryName {
            get { return BackingStore?.Get<string>("sourceDirectoryName"); }
            set { BackingStore?.Set("sourceDirectoryName", value); }
        }
#endif
        /// <summary>Name of the target directory. Must match one of the directory definitions in synchronizationSchema.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TargetDirectoryName {
            get { return BackingStore?.Get<string?>("targetDirectoryName"); }
            set { BackingStore?.Set("targetDirectoryName", value); }
        }
#nullable restore
#else
        public string TargetDirectoryName {
            get { return BackingStore?.Get<string>("targetDirectoryName"); }
            set { BackingStore?.Set("targetDirectoryName", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new synchronizationRule and sets the default values.
        /// </summary>
        public SynchronizationRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SynchronizationRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SynchronizationRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"containerFilter", n => { ContainerFilter = n.GetObjectValue<Microsoft.Graph.Models.ContainerFilter>(Microsoft.Graph.Models.ContainerFilter.CreateFromDiscriminatorValue); } },
                {"editable", n => { Editable = n.GetBoolValue(); } },
                {"groupFilter", n => { GroupFilter = n.GetObjectValue<Microsoft.Graph.Models.GroupFilter>(Microsoft.Graph.Models.GroupFilter.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<StringKeyStringValuePair>(StringKeyStringValuePair.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"objectMappings", n => { ObjectMappings = n.GetCollectionOfObjectValues<ObjectMapping>(ObjectMapping.CreateFromDiscriminatorValue)?.ToList(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"priority", n => { Priority = n.GetIntValue(); } },
                {"sourceDirectoryName", n => { SourceDirectoryName = n.GetStringValue(); } },
                {"targetDirectoryName", n => { TargetDirectoryName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Models.ContainerFilter>("containerFilter", ContainerFilter);
            writer.WriteBoolValue("editable", Editable);
            writer.WriteObjectValue<Microsoft.Graph.Models.GroupFilter>("groupFilter", GroupFilter);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<StringKeyStringValuePair>("metadata", Metadata);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<ObjectMapping>("objectMappings", ObjectMappings);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteStringValue("sourceDirectoryName", SourceDirectoryName);
            writer.WriteStringValue("targetDirectoryName", TargetDirectoryName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
