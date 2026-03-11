
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request schema for batched feedback delta queries with multiple feedback keys.
    /// </summary>
    public sealed partial class QueryFeedbackDeltaBatch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("baseline_session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid BaselineSessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparison_session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ComparisonSessionIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> FeedbackKeys { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFeedbackDeltaBatch" /> class.
        /// </summary>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryFeedbackDeltaBatch(
            global::System.Guid baselineSessionId,
            global::System.Collections.Generic.IList<global::System.Guid> comparisonSessionIds,
            global::System.Collections.Generic.IList<string> feedbackKeys,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters)
        {
            this.BaselineSessionId = baselineSessionId;
            this.ComparisonSessionIds = comparisonSessionIds ?? throw new global::System.ArgumentNullException(nameof(comparisonSessionIds));
            this.FeedbackKeys = feedbackKeys ?? throw new global::System.ArgumentNullException(nameof(feedbackKeys));
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryFeedbackDeltaBatch" /> class.
        /// </summary>
        public QueryFeedbackDeltaBatch()
        {
        }
    }
}