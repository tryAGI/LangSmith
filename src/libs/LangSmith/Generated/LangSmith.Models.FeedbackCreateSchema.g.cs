
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, object>))]
        public global::LangSmith.AnyOf<double?, int?, bool?, object>? Score { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<double?, int?, bool?, string, object, object>))]
        public global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>? Value { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, string, object>))]
        public global::LangSmith.AnyOf<object, string, object>? Correction { get; set; }

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
        /// Required unless the feedback is addressed by agent_id and agent_environment. The ID of the tracing project (session) the feedback belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent's id, not a UUID: 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit (e.g. support-agent). Addresses the tracing project through an Agent instead of session_id. Sent together with agent_environment, and never alongside session_id. The Agent and the environment must already exist; sending feedback does not create them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent environment whose tracing project the feedback belongs to. Matched case-insensitively. Sent together with agent_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_environment")]
        public global::LangSmith.FeedbackCreateSchemaAgentEnvironment? AgentEnvironment { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        public global::LangSmith.FeedbackConfig? FeedbackConfig { get; set; }

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
        /// Required unless the feedback is addressed by agent_id and agent_environment. The ID of the tracing project (session) the feedback belongs to.
        /// </param>
        /// <param name="agentId">
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent's id, not a UUID: 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit (e.g. support-agent). Addresses the tracing project through an Agent instead of session_id. Sent together with agent_environment, and never alongside session_id. The Agent and the environment must already exist; sending feedback does not create them.
        /// </param>
        /// <param name="agentEnvironment">
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent environment whose tracing project the feedback belongs to. Matched case-insensitively. Sent together with agent_id.
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="feedbackThreadId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="extra"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackCreateSchema(
            string key,
            global::System.DateTime? createdAt,
            global::System.DateTime? modifiedAt,
            global::LangSmith.AnyOf<double?, int?, bool?, object>? score,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>? value,
            string? comment,
            global::LangSmith.AnyOf<object, string, object>? correction,
            global::System.Guid? feedbackGroupId,
            global::System.Guid? comparativeExperimentId,
            global::System.Guid? runId,
            global::System.Guid? sessionId,
            string? agentId,
            global::LangSmith.FeedbackCreateSchemaAgentEnvironment? agentEnvironment,
            global::System.Guid? traceId,
            global::System.DateTime? startTime,
            string? feedbackThreadId,
            bool? extendTraceRetention,
            global::System.Guid? id,
            global::LangSmith.FeedbackSourceVariant12? feedbackSource,
            global::LangSmith.FeedbackConfig? feedbackConfig,
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
            this.AgentId = agentId;
            this.AgentEnvironment = agentEnvironment;
            this.TraceId = traceId;
            this.StartTime = startTime;
            this.FeedbackThreadId = feedbackThreadId;
            this.ExtendTraceRetention = extendTraceRetention;
            this.Id = id;
            this.FeedbackSource = feedbackSource;
            this.FeedbackConfig = feedbackConfig;
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