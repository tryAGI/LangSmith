
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsCreateEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluator")]
        public global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? CodeEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_evaluator")]
        public global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? LlmEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeJsonConverter))]
        public global::LangSmith.EvaluatorsEvaluatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCreateEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="codeEvaluator"></param>
        /// <param name="llmEvaluator"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsCreateEvaluatorRequest(
            global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? codeEvaluator,
            global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? llmEvaluator,
            string? name,
            global::LangSmith.EvaluatorsEvaluatorType? type)
        {
            this.CodeEvaluator = codeEvaluator;
            this.LlmEvaluator = llmEvaluator;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsCreateEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsCreateEvaluatorRequest()
        {
        }
    }
}