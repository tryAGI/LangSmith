
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedbackFeedbackCreateSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comment")]
        public string? Comment { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public string? ComparativeExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("correction")]
        public object? Correction { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public bool? Error { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config")]
        public global::LangSmith.FeedbackFeedbackConfig? FeedbackConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_group_id")]
        public string? FeedbackGroupId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_source")]
        public global::LangSmith.FeedbackFeedbackSource? FeedbackSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        public string? ModifiedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public object? Score { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public string? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFeedbackCreateSchema" /> class.
        /// </summary>
        /// <param name="comment"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="correction"></param>
        /// <param name="createdAt"></param>
        /// <param name="error"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="id"></param>
        /// <param name="key"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="runId"></param>
        /// <param name="score"></param>
        /// <param name="sessionId"></param>
        /// <param name="traceId"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FeedbackFeedbackCreateSchema(
            string? comment,
            string? comparativeExperimentId,
            object? correction,
            string? createdAt,
            bool? error,
            global::LangSmith.FeedbackFeedbackConfig? feedbackConfig,
            string? feedbackGroupId,
            global::LangSmith.FeedbackFeedbackSource? feedbackSource,
            string? id,
            string? key,
            string? modifiedAt,
            string? runId,
            object? score,
            string? sessionId,
            string? traceId,
            object? value)
        {
            this.Comment = comment;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.Correction = correction;
            this.CreatedAt = createdAt;
            this.Error = error;
            this.FeedbackConfig = feedbackConfig;
            this.FeedbackGroupId = feedbackGroupId;
            this.FeedbackSource = feedbackSource;
            this.Id = id;
            this.Key = key;
            this.ModifiedAt = modifiedAt;
            this.RunId = runId;
            this.Score = score;
            this.SessionId = sessionId;
            this.TraceId = traceId;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedbackFeedbackCreateSchema" /> class.
        /// </summary>
        public FeedbackFeedbackCreateSchema()
        {
        }
    }
}