
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Result of creating a composite score as a code evaluator + run rule.
    /// </summary>
    public sealed partial class CompositeEvaluatorCreated
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid EvaluatorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeEvaluatorCreated" /> class.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="evaluatorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeEvaluatorCreated(
            global::System.Guid ruleId,
            global::System.Guid evaluatorId)
        {
            this.RuleId = ruleId;
            this.EvaluatorId = evaluatorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeEvaluatorCreated" /> class.
        /// </summary>
        public CompositeEvaluatorCreated()
        {
        }

    }
}