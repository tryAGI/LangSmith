
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RunsanalyticsMetricParams
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bucket_count")]
        public int? BucketCount { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        public string? FeedbackKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        public double? P { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsMetricParams" /> class.
        /// </summary>
        /// <param name="bucketCount"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="p"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunsanalyticsMetricParams(
            int? bucketCount,
            string? feedbackKey,
            double? p)
        {
            this.BucketCount = bucketCount;
            this.FeedbackKey = feedbackKey;
            this.P = p;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunsanalyticsMetricParams" /> class.
        /// </summary>
        public RunsanalyticsMetricParams()
        {
        }

    }
}