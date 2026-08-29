
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Structured fields describing an adapter parse failure.
    /// </summary>
    public sealed partial class SharedParseErrorDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("adapter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Adapter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedParseErrorDetails" /> class.
        /// </summary>
        /// <param name="adapter"></param>
        /// <param name="itemType"></param>
        /// <param name="runId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SharedParseErrorDetails(
            string adapter,
            string itemType,
            string? runId)
        {
            this.Adapter = adapter ?? throw new global::System.ArgumentNullException(nameof(adapter));
            this.ItemType = itemType ?? throw new global::System.ArgumentNullException(nameof(itemType));
            this.RunId = runId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SharedParseErrorDetails" /> class.
        /// </summary>
        public SharedParseErrorDetails()
        {
        }

    }
}