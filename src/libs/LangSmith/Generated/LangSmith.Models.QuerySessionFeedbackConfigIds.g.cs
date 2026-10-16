
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Experiments, and optionally feedback keys, to list feedback config ids for.
    /// </summary>
    public sealed partial class QuerySessionFeedbackConfigIds
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_keys")]
        public global::System.Collections.Generic.IList<string>? FeedbackKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySessionFeedbackConfigIds" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="cursor"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuerySessionFeedbackConfigIds(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            global::System.Collections.Generic.IList<string>? feedbackKeys,
            string? cursor,
            int? pageSize)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.FeedbackKeys = feedbackKeys;
            this.Cursor = cursor;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuerySessionFeedbackConfigIds" /> class.
        /// </summary>
        public QuerySessionFeedbackConfigIds()
        {
        }

    }
}