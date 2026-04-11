
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsUpdateEvaluatorRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluator")]
        public global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? CodeEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_evaluator")]
        public global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? LlmEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateEvaluatorRequest" /> class.
        /// </summary>
        /// <param name="codeEvaluator"></param>
        /// <param name="llmEvaluator"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsUpdateEvaluatorRequest(
            global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? codeEvaluator,
            global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? llmEvaluator,
            string? name)
        {
            this.CodeEvaluator = codeEvaluator;
            this.LlmEvaluator = llmEvaluator;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsUpdateEvaluatorRequest" /> class.
        /// </summary>
        public EvaluatorsUpdateEvaluatorRequest()
        {
        }
    }
}