
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartFeedbackScoreMetricScalarParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FeedbackKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricScalarParams" /> class.
        /// </summary>
        /// <param name="feedbackKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFeedbackScoreMetricScalarParams(
            string feedbackKey)
        {
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricScalarParams" /> class.
        /// </summary>
        public CustomChartFeedbackScoreMetricScalarParams()
        {
        }

    }
}