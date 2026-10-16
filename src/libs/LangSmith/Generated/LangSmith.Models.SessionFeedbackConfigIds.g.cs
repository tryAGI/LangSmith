
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The feedback configs an experiment's scores for one key were written against.
    /// </summary>
    public sealed partial class SessionFeedbackConfigIds
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_session_level")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsSessionLevel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_config_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FeedbackConfigIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_scores_without_config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasScoresWithoutConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackConfigIds" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="isSessionLevel"></param>
        /// <param name="feedbackConfigIds"></param>
        /// <param name="hasScoresWithoutConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionFeedbackConfigIds(
            global::System.Guid sessionId,
            string feedbackKey,
            bool isSessionLevel,
            global::System.Collections.Generic.IList<global::System.Guid> feedbackConfigIds,
            bool hasScoresWithoutConfig)
        {
            this.SessionId = sessionId;
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
            this.IsSessionLevel = isSessionLevel;
            this.FeedbackConfigIds = feedbackConfigIds ?? throw new global::System.ArgumentNullException(nameof(feedbackConfigIds));
            this.HasScoresWithoutConfig = hasScoresWithoutConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionFeedbackConfigIds" /> class.
        /// </summary>
        public SessionFeedbackConfigIds()
        {
        }

    }
}