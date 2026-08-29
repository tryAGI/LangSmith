
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomChartFeedbackScoreMetricPercentileParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P { get; set; }

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
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricPercentileParams" /> class.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="feedbackKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFeedbackScoreMetricPercentileParams(
            double p,
            string feedbackKey)
        {
            this.P = p;
            this.FeedbackKey = feedbackKey ?? throw new global::System.ArgumentNullException(nameof(feedbackKey));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricPercentileParams" /> class.
        /// </summary>
        public CustomChartFeedbackScoreMetricPercentileParams()
        {
        }

    }
}