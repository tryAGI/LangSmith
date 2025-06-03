
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExamplesExamplesUpdatedResponse
    {
        /// <summary>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Example: [["123e4567-e89b-12d3-a456-426614174000"]]
        /// </summary>
        /// <example>[["123e4567-e89b-12d3-a456-426614174000"]]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        public global::System.Collections.Generic.IList<string>? ExampleIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesExamplesUpdatedResponse" /> class.
        /// </summary>
        /// <param name="count">
        /// Example: 1
        /// </param>
        /// <param name="exampleIds">
        /// Example: [["123e4567-e89b-12d3-a456-426614174000"]]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesExamplesUpdatedResponse(
            int? count,
            global::System.Collections.Generic.IList<string>? exampleIds)
        {
            this.Count = count;
            this.ExampleIds = exampleIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesExamplesUpdatedResponse" /> class.
        /// </summary>
        public ExamplesExamplesUpdatedResponse()
        {
        }
    }
}