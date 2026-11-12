
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RulesRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_annotation_queue_id")]
        public global::System.Guid? AddToAnnotationQueueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_annotation_queue_name")]
        public string? AddToAnnotationQueueName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset_id")]
        public global::System.Guid? AddToDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset_name")]
        public string? AddToDatasetName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset_prefer_correction")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AddToDatasetPreferCorrection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public global::System.Collections.Generic.IList<global::LangSmith.RulesAlert>? Alerts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alignment_annotation_queue_id")]
        public global::System.Guid? AlignmentAnnotationQueueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_completed_at")]
        public global::System.DateTime? BackfillCompletedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_error")]
        public string? BackfillError { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_from")]
        public global::System.DateTime? BackfillFrom { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_id")]
        public global::System.Guid? BackfillId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_progress")]
        public double? BackfillProgress { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_status")]
        public string? BackfillStatus { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluators")]
        public global::System.Collections.Generic.IList<global::LangSmith.RulesCodeEvaluator>? CodeEvaluators { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corrections_dataset_id")]
        public global::System.Guid? CorrectionsDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_name")]
        public string? DatasetName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective_spend_limit")]
        public global::LangSmith.RulesSpendLimit? EffectiveSpendLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        public global::System.Guid? EvaluatorId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_name")]
        public string? EvaluatorName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_type")]
        public string? EvaluatorType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EvaluatorVersion { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::LangSmith.RulesEvaluator>? Evaluators { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_annotation_queue_trace_retention")]
        public bool? ExtendAnnotationQueueTraceRetention { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_dataset_trace_retention")]
        public bool? ExtendDatasetTraceRetention { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_evaluator_trace_retention")]
        public bool? ExtendEvaluatorTraceRetention { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_only")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool ExtendOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_webhook_trace_retention")]
        public bool? ExtendWebhookTraceRetention { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RulesRuleGroupByJsonConverter))]
        public global::LangSmith.RulesRuleGroupBy? GroupBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_extended_stats")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IncludeExtendedStats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_managed_evaluator")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsManagedEvaluator { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tracing_disabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsTracingDisabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::LangSmith.RulesSpendLimit? SpendLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_usd")]
        public double? SpendUsd { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_filter")]
        public string? ThreadFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_count")]
        public int? TraceCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Transient { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_corrections_dataset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool UseCorrectionsDataset { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::LangSmith.RulesWebhook>? Webhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesRule" /> class.
        /// </summary>
        /// <param name="addToDatasetPreferCorrection"></param>
        /// <param name="createdAt"></param>
        /// <param name="displayName"></param>
        /// <param name="evaluatorVersion"></param>
        /// <param name="extendOnly"></param>
        /// <param name="id"></param>
        /// <param name="includeExtendedStats"></param>
        /// <param name="isEnabled"></param>
        /// <param name="isManagedEvaluator"></param>
        /// <param name="isTracingDisabled"></param>
        /// <param name="samplingRate"></param>
        /// <param name="tenantId"></param>
        /// <param name="transient"></param>
        /// <param name="updatedAt"></param>
        /// <param name="useCorrectionsDataset"></param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToAnnotationQueueName"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetName"></param>
        /// <param name="alerts"></param>
        /// <param name="alignmentAnnotationQueueId"></param>
        /// <param name="backfillCompletedAt"></param>
        /// <param name="backfillError"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="backfillId"></param>
        /// <param name="backfillProgress"></param>
        /// <param name="backfillStatus"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="correctionsDatasetId"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="effectiveSpendLimit"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="evaluatorName"></param>
        /// <param name="evaluatorType"></param>
        /// <param name="evaluators"></param>
        /// <param name="extendAnnotationQueueTraceRetention"></param>
        /// <param name="extendDatasetTraceRetention"></param>
        /// <param name="extendEvaluatorTraceRetention"></param>
        /// <param name="extendWebhookTraceRetention"></param>
        /// <param name="filter"></param>
        /// <param name="groupBy"></param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="spendLimit"></param>
        /// <param name="spendUsd"></param>
        /// <param name="threadFilter"></param>
        /// <param name="traceCount"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="webhooks"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RulesRule(
            bool addToDatasetPreferCorrection,
            global::System.DateTime createdAt,
            string displayName,
            int evaluatorVersion,
            bool extendOnly,
            global::System.Guid id,
            bool includeExtendedStats,
            bool isEnabled,
            bool isManagedEvaluator,
            bool isTracingDisabled,
            double samplingRate,
            global::System.Guid tenantId,
            bool transient,
            global::System.DateTime updatedAt,
            bool useCorrectionsDataset,
            global::System.Guid? addToAnnotationQueueId,
            string? addToAnnotationQueueName,
            global::System.Guid? addToDatasetId,
            string? addToDatasetName,
            global::System.Collections.Generic.IList<global::LangSmith.RulesAlert>? alerts,
            global::System.Guid? alignmentAnnotationQueueId,
            global::System.DateTime? backfillCompletedAt,
            string? backfillError,
            global::System.DateTime? backfillFrom,
            global::System.Guid? backfillId,
            double? backfillProgress,
            string? backfillStatus,
            global::System.Collections.Generic.IList<global::LangSmith.RulesCodeEvaluator>? codeEvaluators,
            global::System.Guid? correctionsDatasetId,
            global::System.Guid? datasetId,
            string? datasetName,
            global::LangSmith.RulesSpendLimit? effectiveSpendLimit,
            global::System.Guid? evaluatorId,
            string? evaluatorName,
            string? evaluatorType,
            global::System.Collections.Generic.IList<global::LangSmith.RulesEvaluator>? evaluators,
            bool? extendAnnotationQueueTraceRetention,
            bool? extendDatasetTraceRetention,
            bool? extendEvaluatorTraceRetention,
            bool? extendWebhookTraceRetention,
            string? filter,
            global::LangSmith.RulesRuleGroupBy? groupBy,
            int? numFewShotExamples,
            global::System.Guid? projectId,
            string? projectName,
            global::LangSmith.RulesSpendLimit? spendLimit,
            double? spendUsd,
            string? threadFilter,
            int? traceCount,
            string? traceFilter,
            string? treeFilter,
            global::System.Collections.Generic.IList<global::LangSmith.RulesWebhook>? webhooks)
        {
            this.AddToAnnotationQueueId = addToAnnotationQueueId;
            this.AddToAnnotationQueueName = addToAnnotationQueueName;
            this.AddToDatasetId = addToDatasetId;
            this.AddToDatasetName = addToDatasetName;
            this.AddToDatasetPreferCorrection = addToDatasetPreferCorrection;
            this.Alerts = alerts;
            this.AlignmentAnnotationQueueId = alignmentAnnotationQueueId;
            this.BackfillCompletedAt = backfillCompletedAt;
            this.BackfillError = backfillError;
            this.BackfillFrom = backfillFrom;
            this.BackfillId = backfillId;
            this.BackfillProgress = backfillProgress;
            this.BackfillStatus = backfillStatus;
            this.CodeEvaluators = codeEvaluators;
            this.CorrectionsDatasetId = correctionsDatasetId;
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.DatasetName = datasetName;
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.EffectiveSpendLimit = effectiveSpendLimit;
            this.EvaluatorId = evaluatorId;
            this.EvaluatorName = evaluatorName;
            this.EvaluatorType = evaluatorType;
            this.EvaluatorVersion = evaluatorVersion;
            this.Evaluators = evaluators;
            this.ExtendAnnotationQueueTraceRetention = extendAnnotationQueueTraceRetention;
            this.ExtendDatasetTraceRetention = extendDatasetTraceRetention;
            this.ExtendEvaluatorTraceRetention = extendEvaluatorTraceRetention;
            this.ExtendOnly = extendOnly;
            this.ExtendWebhookTraceRetention = extendWebhookTraceRetention;
            this.Filter = filter;
            this.GroupBy = groupBy;
            this.Id = id;
            this.IncludeExtendedStats = includeExtendedStats;
            this.IsEnabled = isEnabled;
            this.IsManagedEvaluator = isManagedEvaluator;
            this.IsTracingDisabled = isTracingDisabled;
            this.NumFewShotExamples = numFewShotExamples;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.SamplingRate = samplingRate;
            this.SpendLimit = spendLimit;
            this.SpendUsd = spendUsd;
            this.TenantId = tenantId;
            this.ThreadFilter = threadFilter;
            this.TraceCount = traceCount;
            this.TraceFilter = traceFilter;
            this.Transient = transient;
            this.TreeFilter = treeFilter;
            this.UpdatedAt = updatedAt;
            this.UseCorrectionsDataset = useCorrectionsDataset;
            this.Webhooks = webhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RulesRule" /> class.
        /// </summary>
        public RulesRule()
        {
        }

    }
}