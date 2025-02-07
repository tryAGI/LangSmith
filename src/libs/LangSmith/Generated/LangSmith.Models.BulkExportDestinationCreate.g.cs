
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BulkExportDestinationCreate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("destination_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.BulkExportDestinationTypeJsonConverter))]
        public global::LangSmith.BulkExportDestinationType? DestinationType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.BulkExportDestinationS3Config Config { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.BulkExportDestinationS3Credentials Credentials { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationCreate" /> class.
        /// </summary>
        /// <param name="destinationType"></param>
        /// <param name="displayName"></param>
        /// <param name="config"></param>
        /// <param name="credentials"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BulkExportDestinationCreate(
            string displayName,
            global::LangSmith.BulkExportDestinationS3Config config,
            global::LangSmith.BulkExportDestinationS3Credentials credentials,
            global::LangSmith.BulkExportDestinationType? destinationType)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Credentials = credentials ?? throw new global::System.ArgumentNullException(nameof(credentials));
            this.DestinationType = destinationType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BulkExportDestinationCreate" /> class.
        /// </summary>
        public BulkExportDestinationCreate()
        {
        }
    }
}