
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request body for evaluating an experiment.
    /// </summary>
    public sealed partial class EvaluateExperimentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Guid RuleId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateExperimentRequest" /> class.
        /// </summary>
        /// <param name="ruleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluateExperimentRequest(
            global::System.Guid ruleId)
        {
            this.RuleId = ruleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluateExperimentRequest" /> class.
        /// </summary>
        public EvaluateExperimentRequest()
        {
        }
    }
}