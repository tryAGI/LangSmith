
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// TracerSession schema.
    /// </summary>
    public sealed partial class Session
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        public global::System.DateTime? EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dataset_id")]
        public global::System.Guid? DefaultDatasetId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_dataset_id")]
        public global::System.Guid? ReferenceDatasetId { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        public global::LangSmith.SessionTraceTier? TraceTier { get; set; }

        /// <summary>
        /// Retention in days for traces while trace_tier is longlived. One of the deployment's allowed values (allowed_longlived_ttl_days in /info), up to the maximum of the deployment. The value is kept while trace_tier is shortlived. Null means the project uses the workspace retention.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_count")]
        public int? RunCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p50")]
        public double? LatencyP50 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latency_p99")]
        public double? LatencyP99 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p50")]
        public double? FirstTokenP50 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_token_p99")]
        public double? FirstTokenP99 { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        public double? TotalCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cost")]
        public double? PromptCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_cost")]
        public double? CompletionCost { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid TenantId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_start_time")]
        public global::System.DateTime? LastRunStartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_run_start_time_live")]
        public global::System.DateTime? LastRunStartTimeLive { get; set; }

        /// <summary>
        /// Feedback on the session's runs, by feedback key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? FeedbackStats { get; set; }

        /// <summary>
        /// Feedback on the session itself, by feedback key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_feedback_stats")]
        public global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? SessionFeedbackStats { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_facets")]
        public global::System.Collections.Generic.IList<object>? RunFacets { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_rate")]
        public double? ErrorRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_rate")]
        public double? StreamingRate { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("test_run_number")]
        public int? TestRunNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_progress")]
        public global::LangSmith.ExperimentProgress? ExperimentProgress { get; set; }

        /// <summary>
        /// `PROJECT` for a tracing project, `AGENT` for an Agent's tracing project, or `EXPERIMENT` for an evaluation run against a dataset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SessionTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SessionType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="tenantId"></param>
        /// <param name="type">
        /// `PROJECT` for a tracing project, `AGENT` for an Agent's tracing project, or `EXPERIMENT` for an evaluation run against a dataset.
        /// </param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="longlivedTtlDays">
        /// Retention in days for traces while trace_tier is longlived. One of the deployment's allowed values (allowed_longlived_ttl_days in /info), up to the maximum of the deployment. The value is kept while trace_tier is shortlived. Null means the project uses the workspace retention.
        /// </param>
        /// <param name="runCount"></param>
        /// <param name="latencyP50"></param>
        /// <param name="latencyP99"></param>
        /// <param name="firstTokenP50"></param>
        /// <param name="firstTokenP99"></param>
        /// <param name="totalTokens"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="totalCost"></param>
        /// <param name="promptCost"></param>
        /// <param name="completionCost"></param>
        /// <param name="lastRunStartTime"></param>
        /// <param name="lastRunStartTimeLive"></param>
        /// <param name="feedbackStats">
        /// Feedback on the session's runs, by feedback key.
        /// </param>
        /// <param name="sessionFeedbackStats">
        /// Feedback on the session itself, by feedback key.
        /// </param>
        /// <param name="runFacets"></param>
        /// <param name="errorRate"></param>
        /// <param name="streamingRate"></param>
        /// <param name="testRunNumber"></param>
        /// <param name="experimentProgress"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Session(
            global::System.DateTime startTime,
            string name,
            global::System.Guid id,
            global::System.Guid tenantId,
            global::LangSmith.SessionType type,
            global::System.DateTime? endTime,
            object? extra,
            string? description,
            global::System.Guid? defaultDatasetId,
            global::System.Guid? referenceDatasetId,
            global::LangSmith.SessionTraceTier? traceTier,
            int? longlivedTtlDays,
            int? runCount,
            double? latencyP50,
            double? latencyP99,
            double? firstTokenP50,
            double? firstTokenP99,
            int? totalTokens,
            int? promptTokens,
            int? completionTokens,
            double? totalCost,
            double? promptCost,
            double? completionCost,
            global::System.DateTime? lastRunStartTime,
            global::System.DateTime? lastRunStartTimeLive,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? feedbackStats,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.SessionFeedbackStat>? sessionFeedbackStats,
            global::System.Collections.Generic.IList<object>? runFacets,
            double? errorRate,
            double? streamingRate,
            int? testRunNumber,
            global::LangSmith.ExperimentProgress? experimentProgress)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Extra = extra;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.DefaultDatasetId = defaultDatasetId;
            this.ReferenceDatasetId = referenceDatasetId;
            this.TraceTier = traceTier;
            this.LonglivedTtlDays = longlivedTtlDays;
            this.Id = id;
            this.RunCount = runCount;
            this.LatencyP50 = latencyP50;
            this.LatencyP99 = latencyP99;
            this.FirstTokenP50 = firstTokenP50;
            this.FirstTokenP99 = firstTokenP99;
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalCost = totalCost;
            this.PromptCost = promptCost;
            this.CompletionCost = completionCost;
            this.TenantId = tenantId;
            this.LastRunStartTime = lastRunStartTime;
            this.LastRunStartTimeLive = lastRunStartTimeLive;
            this.FeedbackStats = feedbackStats;
            this.SessionFeedbackStats = sessionFeedbackStats;
            this.RunFacets = runFacets;
            this.ErrorRate = errorRate;
            this.StreamingRate = streamingRate;
            this.TestRunNumber = testRunNumber;
            this.ExperimentProgress = experimentProgress;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Session" /> class.
        /// </summary>
        public Session()
        {
        }

    }
}