
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TriggerRulesRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rule_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? RuleIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRulesRequest" /> class.
        /// </summary>
        /// <param name="ruleIds"></param>
        /// <param name="datasetId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TriggerRulesRequest(
            global::System.Collections.Generic.IList<global::System.Guid>? ruleIds,
            global::System.Guid? datasetId)
        {
            this.RuleIds = ruleIds;
            this.DatasetId = datasetId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerRulesRequest" /> class.
        /// </summary>
        public TriggerRulesRequest()
        {
        }
    }
}