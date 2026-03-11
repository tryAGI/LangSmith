
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Auto-generated clustering job config (not persisted; frontend creates the config).
    /// </summary>
    public sealed partial class GenerateClusteringJobConfigResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SummaryPrompt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribute_schemas")]
        public global::System.Collections.Generic.Dictionary<string, object>? AttributeSchemas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateClusteringJobConfigResponse" /> class.
        /// </summary>
        /// <param name="summaryPrompt"></param>
        /// <param name="name"></param>
        /// <param name="attributeSchemas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenerateClusteringJobConfigResponse(
            string summaryPrompt,
            string? name,
            global::System.Collections.Generic.Dictionary<string, object>? attributeSchemas)
        {
            this.SummaryPrompt = summaryPrompt ?? throw new global::System.ArgumentNullException(nameof(summaryPrompt));
            this.Name = name;
            this.AttributeSchemas = attributeSchemas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateClusteringJobConfigResponse" /> class.
        /// </summary>
        public GenerateClusteringJobConfigResponse()
        {
        }
    }
}