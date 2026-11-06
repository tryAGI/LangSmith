
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExamplesBulkUpdateMetadataResponse
    {
        /// <summary>
        /// One entry per submitted example ID, in request order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statuses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus> Statuses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataResponse" /> class.
        /// </summary>
        /// <param name="statuses">
        /// One entry per submitted example ID, in request order.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesBulkUpdateMetadataResponse(
            global::System.Collections.Generic.IList<global::LangSmith.ExamplesBulkUpdateMetadataStatus> statuses)
        {
            this.Statuses = statuses ?? throw new global::System.ArgumentNullException(nameof(statuses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesBulkUpdateMetadataResponse" /> class.
        /// </summary>
        public ExamplesBulkUpdateMetadataResponse()
        {
        }

    }
}