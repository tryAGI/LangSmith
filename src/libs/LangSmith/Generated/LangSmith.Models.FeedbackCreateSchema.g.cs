
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema used for creating feedback.
    /// </summary>
    public sealed partial class FeedbackCreateSchema
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public global::System.DateTime? ModifiedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?>))]
        public global::LangSmith.AnyOf<double?, int?, bool?>? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object>))]
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object>? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string>))]
        public global::LangSmith.AnyOf<object, string>? Correction { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_group_id")]
        public global::System.Guid? FeedbackGroupId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public global::System.Guid? RunId { get; set; }

        /// <summary>
        /// Required unless the feedback is addressed by address. The ID of the tracing project (session) the feedback belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// Addresses the tracing project through an Agent environment, as lrn:agents/{id}/environments/{environment}, instead of session_id. The id is 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit. The environment is local, development, staging, or production, matched case-insensitively. Never combined with session_id. The Agent and the environment must already exist; sending feedback does not create them. Self-hosted deployments need LangSmith v0.18 or later.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("address")]
        public string? Address { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_thread_id")]
        public string? FeedbackThreadId { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extend_trace_retention")]
        public bool? ExtendTraceRetention { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_source")]
        public global::LangSmith.FeedbackSourceVariant12? FeedbackSource { get; set; }

        /// <summary>
        /// The scale the score is checked against. If the feedback key already has a feedback config, this must match it exactly or the request is rejected; if it has none, this becomes the key's feedback config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        public global::LangSmith.FeedbackConfig? FeedbackConfig { get; set; }

        /// <summary>
        /// The ID of the feedback config this feedback was written against. It must be a feedback config for this feedback key in the same workspace, or the feedback is rejected. It doesn't change how the score is checked; feedback_config does that. If omitted, the server may record the key's enforced feedback config, or the one created for the key by this request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config_id")]
        public global::System.Guid? FeedbackConfigId { get; set; }

        /// <summary>
        /// Deprecated. Use `extra.error` instead. If both values are provided, `error` takes precedence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public bool? Error { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra")]
        public object? Extra { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateSchema" /> class.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId">
        /// Required unless the feedback is addressed by address. The ID of the tracing project (session) the feedback belongs to.
        /// </param>
        /// <param name="address">
        /// Addresses the tracing project through an Agent environment, as lrn:agents/{id}/environments/{environment}, instead of session_id. The id is 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit. The environment is local, development, staging, or production, matched case-insensitively. Never combined with session_id. The Agent and the environment must already exist; sending feedback does not create them. Self-hosted deployments need LangSmith v0.18 or later.
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="feedbackThreadId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig">
        /// The scale the score is checked against. If the feedback key already has a feedback config, this must match it exactly or the request is rejected; if it has none, this becomes the key's feedback config.
        /// </param>
        /// <param name="feedbackConfigId">
        /// The ID of the feedback config this feedback was written against. It must be a feedback config for this feedback key in the same workspace, or the feedback is rejected. It doesn't change how the score is checked; feedback_config does that. If omitted, the server may record the key's enforced feedback config, or the one created for the key by this request.
        /// </param>
        /// <param name="extra"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateSchema(
            string key,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            global::LangSmith.AnyOf<double?, int?, bool?>? score,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object>? value,
            string? comment,
            global::LangSmith.AnyOf<object, string>? correction,
            global::System.Guid? feedbackGroupId,
            global::System.Guid? comparativeExperimentId,
            global::System.Guid? runId,
            global::System.Guid? sessionId,
            string? address,
            global::System.Guid? traceId,
            global::System.DateTime? startTime,
            string? feedbackThreadId,
            bool? extendTraceRetention,
            global::System.Guid? id,
            global::LangSmith.FeedbackSourceVariant12? feedbackSource,
            global::LangSmith.FeedbackConfig? feedbackConfig,
            global::System.Guid? feedbackConfigId,
            object? extra)
        {
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Score = score;
            this.Value = value;
            this.Comment = comment;
            this.Correction = correction;
            this.FeedbackGroupId = feedbackGroupId;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.RunId = runId;
            this.SessionId = sessionId;
            this.Address = address;
            this.TraceId = traceId;
            this.StartTime = startTime;
            this.FeedbackThreadId = feedbackThreadId;
            this.ExtendTraceRetention = extendTraceRetention;
            this.Id = id;
            this.FeedbackSource = feedbackSource;
            this.FeedbackConfig = feedbackConfig;
            this.FeedbackConfigId = feedbackConfigId;
            this.Extra = extra;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackCreateSchema" /> class.
        /// </summary>
        public FeedbackCreateSchema()
        {
        }

    }
}