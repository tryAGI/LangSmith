
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EvaluatorsSpendGroup
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public string? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("days")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? Days { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        public string? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_name")]
        public string? EvaluatorName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_total_spend_usd")]
        public double? PrevTotalSpendUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prev_total_trace_count")]
        public int? PrevTotalTraceCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_rule_id")]
        public string? RunRuleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_rule_name")]
        public string? RunRuleName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::LangSmith.EvaluatorsSpendLimit? SpendLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_spend_usd")]
        public double? TotalSpendUsd { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_trace_count")]
        public int? TotalTraceCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendGroup" /> class.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="days"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="evaluatorName"></param>
        /// <param name="prevTotalSpendUsd"></param>
        /// <param name="prevTotalTraceCount"></param>
        /// <param name="runRuleId"></param>
        /// <param name="runRuleName"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="spendLimit"></param>
        /// <param name="totalSpendUsd"></param>
        /// <param name="totalTraceCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvaluatorsSpendGroup(
            string? datasetId,
            string? datasetName,
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorsSpendDay>? days,
            string? evaluatorId,
            string? evaluatorName,
            double? prevTotalSpendUsd,
            int? prevTotalTraceCount,
            string? runRuleId,
            string? runRuleName,
            string? sessionId,
            string? sessionName,
            global::LangSmith.EvaluatorsSpendLimit? spendLimit,
            double? totalSpendUsd,
            int? totalTraceCount)
        {
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.Days = days;
            this.EvaluatorId = evaluatorId;
            this.EvaluatorName = evaluatorName;
            this.PrevTotalSpendUsd = prevTotalSpendUsd;
            this.PrevTotalTraceCount = prevTotalTraceCount;
            this.RunRuleId = runRuleId;
            this.RunRuleName = runRuleName;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.SpendLimit = spendLimit;
            this.TotalSpendUsd = totalSpendUsd;
            this.TotalTraceCount = totalTraceCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvaluatorsSpendGroup" /> class.
        /// </summary>
        public EvaluatorsSpendGroup()
        {
        }

    }
}