
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExamplesBulkUpdateMetadataStatus
    {
        /// <summary>
        /// Why the example was not updated. Omitted when it was.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The example ID, as submitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// UPDATED if the example's metadata was changed; NOT_FOUND if the example is not in<br/>
        /// the dataset or was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ExamplesBulkUpdateMetadataStatusStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataStatus" /> class.
        /// </summary>
        /// <param name="id">
        /// The example ID, as submitted.
        /// </param>
        /// <param name="status">
        /// UPDATED if the example's metadata was changed; NOT_FOUND if the example is not in<br/>
        /// the dataset or was deleted.
        /// </param>
        /// <param name="description">
        /// Why the example was not updated. Omitted when it was.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesBulkUpdateMetadataStatus(
            global::System.Guid id,
            global::LangSmith.ExamplesBulkUpdateMetadataStatusStatus status,
            string? description)
        {
            this.Description = description;
            this.Id = id;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataStatus" /> class.
        /// </summary>
        public ExamplesBulkUpdateMetadataStatus()
        {
        }

    }
}