
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for validating rules without creating them.<br/>
    /// Extends RunRulesCreateSchema with test data fields for validation.<br/>
    /// Only LLM-as-judge rules (evaluators) are supported, not code_evaluators.<br/>
    /// For trace-level evaluators, provide test_inputs / test_outputs.<br/>
    /// For thread evaluators (group_by="thread_id"), provide test_thread_id +<br/>
    /// session_id instead; the backend fetches and assembles all turns automatically.
    /// </summary>
    public sealed partial class RunRulesValidateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        public global::System.Guid? DatasetId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampling_rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SamplingRate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_filter")]
        public string? TraceFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tree_filter")]
        public string? TreeFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backfill_from")]
        public global::System.DateTime? BackfillFrom { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_corrections_dataset")]
        public bool? UseCorrectionsDataset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_few_shot_examples")]
        public int? NumFewShotExamples { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_only")]
        public bool? ExtendOnly { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_tracing_disabled")]
        public bool? IsTracingDisabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_evaluator_trace_retention")]
        public bool? ExtendEvaluatorTraceRetention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_dataset_trace_retention")]
        public bool? ExtendDatasetTraceRetention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_annotation_queue_trace_retention")]
        public bool? ExtendAnnotationQueueTraceRetention { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_webhook_trace_retention")]
        public bool? ExtendWebhookTraceRetention { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transient")]
        public bool? Transient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_annotation_queue_id")]
        public global::System.Guid? AddToAnnotationQueueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset_id")]
        public global::System.Guid? AddToDatasetId { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("add_to_dataset_prefer_correction")]
        public bool? AddToDatasetPreferCorrection { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluators")]
        public global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? Evaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_evaluators")]
        public global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? CodeEvaluators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_id")]
        public global::System.Guid? EvaluatorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alerts")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? Alerts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhooks")]
        public global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? Webhooks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluator_version")]
        public int? EvaluatorVersion { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_alignment_queue")]
        public bool? CreateAlignmentQueue { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_extended_stats")]
        public bool? IncludeExtendedStats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public string? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::LangSmith.RunRuleSpendLimitSchemaInput? SpendLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tracer_session_issue_id")]
        public global::System.Guid? TracerSessionIssueId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_inputs")]
        public object? TestInputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_outputs")]
        public object? TestOutputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_reference_outputs")]
        public object? TestReferenceOutputs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_attachments")]
        public object? TestAttachments { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_thread_id")]
        public string? TestThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesValidateSchema" /> class.
        /// </summary>
        /// <param name="displayName"></param>
        /// <param name="samplingRate"></param>
        /// <param name="sessionId"></param>
        /// <param name="isEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="filter"></param>
        /// <param name="traceFilter"></param>
        /// <param name="treeFilter"></param>
        /// <param name="backfillFrom"></param>
        /// <param name="useCorrectionsDataset">
        /// Default Value: false
        /// </param>
        /// <param name="numFewShotExamples"></param>
        /// <param name="extendOnly">
        /// Default Value: false
        /// </param>
        /// <param name="isTracingDisabled">
        /// Default Value: false
        /// </param>
        /// <param name="extendEvaluatorTraceRetention">
        /// Default Value: false
        /// </param>
        /// <param name="extendDatasetTraceRetention"></param>
        /// <param name="extendAnnotationQueueTraceRetention"></param>
        /// <param name="extendWebhookTraceRetention"></param>
        /// <param name="transient">
        /// Default Value: false
        /// </param>
        /// <param name="addToAnnotationQueueId"></param>
        /// <param name="addToDatasetId"></param>
        /// <param name="addToDatasetPreferCorrection">
        /// Default Value: false
        /// </param>
        /// <param name="evaluators"></param>
        /// <param name="codeEvaluators"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="alerts"></param>
        /// <param name="webhooks"></param>
        /// <param name="evaluatorVersion"></param>
        /// <param name="createAlignmentQueue">
        /// Default Value: false
        /// </param>
        /// <param name="includeExtendedStats">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="spendLimit"></param>
        /// <param name="tracerSessionIssueId"></param>
        /// <param name="testInputs"></param>
        /// <param name="testOutputs"></param>
        /// <param name="testReferenceOutputs"></param>
        /// <param name="testAttachments"></param>
        /// <param name="testThreadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunRulesValidateSchema(
            string displayName,
            double samplingRate,
            global::System.Guid? sessionId,
            bool? isEnabled,
            global::System.Guid? datasetId,
            string? filter,
            string? traceFilter,
            string? treeFilter,
            global::System.DateTime? backfillFrom,
            bool? useCorrectionsDataset,
            int? numFewShotExamples,
            bool? extendOnly,
            bool? isTracingDisabled,
            bool? extendEvaluatorTraceRetention,
            bool? extendDatasetTraceRetention,
            bool? extendAnnotationQueueTraceRetention,
            bool? extendWebhookTraceRetention,
            bool? transient,
            global::System.Guid? addToAnnotationQueueId,
            global::System.Guid? addToDatasetId,
            bool? addToDatasetPreferCorrection,
            global::System.Collections.Generic.IList<global::LangSmith.EvaluatorTopLevel>? evaluators,
            global::System.Collections.Generic.IList<global::LangSmith.CodeEvaluatorTopLevel>? codeEvaluators,
            global::System.Guid? evaluatorId,
            global::System.Collections.Generic.IList<global::LangSmith.RunRulesPagerdutyAlertSchema>? alerts,
            global::System.Collections.Generic.IList<global::LangSmith.RunRulesWebhookSchema>? webhooks,
            int? evaluatorVersion,
            bool? createAlignmentQueue,
            bool? includeExtendedStats,
            string? groupBy,
            global::LangSmith.RunRuleSpendLimitSchemaInput? spendLimit,
            global::System.Guid? tracerSessionIssueId,
            object? testInputs,
            object? testOutputs,
            object? testReferenceOutputs,
            object? testAttachments,
            string? testThreadId)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.SessionId = sessionId;
            this.IsEnabled = isEnabled;
            this.DatasetId = datasetId;
            this.SamplingRate = samplingRate;
            this.Filter = filter;
            this.TraceFilter = traceFilter;
            this.TreeFilter = treeFilter;
            this.BackfillFrom = backfillFrom;
            this.UseCorrectionsDataset = useCorrectionsDataset;
            this.NumFewShotExamples = numFewShotExamples;
            this.ExtendOnly = extendOnly;
            this.IsTracingDisabled = isTracingDisabled;
            this.ExtendEvaluatorTraceRetention = extendEvaluatorTraceRetention;
            this.ExtendDatasetTraceRetention = extendDatasetTraceRetention;
            this.ExtendAnnotationQueueTraceRetention = extendAnnotationQueueTraceRetention;
            this.ExtendWebhookTraceRetention = extendWebhookTraceRetention;
            this.Transient = transient;
            this.AddToAnnotationQueueId = addToAnnotationQueueId;
            this.AddToDatasetId = addToDatasetId;
            this.AddToDatasetPreferCorrection = addToDatasetPreferCorrection;
            this.Evaluators = evaluators;
            this.CodeEvaluators = codeEvaluators;
            this.EvaluatorId = evaluatorId;
            this.Alerts = alerts;
            this.Webhooks = webhooks;
            this.EvaluatorVersion = evaluatorVersion;
            this.CreateAlignmentQueue = createAlignmentQueue;
            this.IncludeExtendedStats = includeExtendedStats;
            this.GroupBy = groupBy;
            this.SpendLimit = spendLimit;
            this.TracerSessionIssueId = tracerSessionIssueId;
            this.TestInputs = testInputs;
            this.TestOutputs = testOutputs;
            this.TestReferenceOutputs = testReferenceOutputs;
            this.TestAttachments = testAttachments;
            this.TestThreadId = testThreadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunRulesValidateSchema" /> class.
        /// </summary>
        public RunRulesValidateSchema()
        {
        }

    }
}