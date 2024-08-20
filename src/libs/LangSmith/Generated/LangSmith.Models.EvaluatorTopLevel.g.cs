
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorTopLevel
    {
        /// <summary>
        /// Evaluator structured output schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("structured")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.EvaluatorStructuredOutput Structured { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}