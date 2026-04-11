
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsEvaluator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluator")]
        public global::LangSmith.EvaluatorsCodeEvaluator? CodeEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_keys")]
        public global::System.Collections.Generic.IList<string>? FeedbackKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Embedded child evaluator (populated based on type)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("llm_evaluator")]
        public global::LangSmith.EvaluatorsLLMEvaluator? LlmEvaluator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_rules")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? RunRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.EvaluatorsEvaluatorTypeJsonConverter))]
        public global::LangSmith.EvaluatorsEvaluatorType? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsEvaluator" /> class.
        /// </summary>
        /// <param name="codeEvaluator"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="id"></param>
        /// <param name="llmEvaluator">
        /// Embedded child evaluator (populated based on type)
        /// </param>
        /// <param name="name"></param>
        /// <param name="runRules"></param>
        /// <param name="tenantId"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsEvaluator(
            global::LangSmith.EvaluatorsCodeEvaluator? codeEvaluator,
            string? createdAt,
            string? createdBy,
            global::System.Collections.Generic.IList<string>? feedbackKeys,
            string? id,
            global::LangSmith.EvaluatorsLLMEvaluator? llmEvaluator,
            string? name,
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsEvaluatorRunRule>? runRules,
            string? tenantId,
            global::LangSmith.EvaluatorsEvaluatorType? type,
            string? updatedAt)
        {
            this.CodeEvaluator = codeEvaluator;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.FeedbackKeys = feedbackKeys;
            this.Id = id;
            this.LlmEvaluator = llmEvaluator;
            this.Name = name;
            this.RunRules = runRules;
            this.TenantId = tenantId;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsEvaluator" /> class.
        /// </summary>
        public EvaluatorsEvaluator()
        {
        }
    }
}