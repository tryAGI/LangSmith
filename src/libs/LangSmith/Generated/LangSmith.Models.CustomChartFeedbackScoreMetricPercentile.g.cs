
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomChartFeedbackScoreMetricPercentile
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"percentile"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "percentile";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"feedback_score"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string Field { get; set; } = "feedback_score";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricPercentile" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="filter"></param>
        /// <param name="type"></param>
        /// <param name="field"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFeedbackScoreMetricPercentile(
            global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams @params,
            string? filter,
            string type = "percentile",
            string field = "feedback_score")
        {
            this.Type = type;
            this.Filter = filter;
            this.Field = field;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricPercentile" /> class.
        /// </summary>
        public CustomChartFeedbackScoreMetricPercentile()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomChartFeedbackScoreMetricPercentile"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CustomChartFeedbackScoreMetricPercentile FromParams(global::LangSmith.CustomChartFeedbackScoreMetricPercentileParams @params)
        {
            return new CustomChartFeedbackScoreMetricPercentile
            {
                Params = @params,
            };
        }

    }
}