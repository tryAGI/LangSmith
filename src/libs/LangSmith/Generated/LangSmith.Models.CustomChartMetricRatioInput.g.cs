
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartMetricRatioInput
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ratio"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "ratio";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numerator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile> Numerator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("denominator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile> Denominator { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricRatioInput" /> class.
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartMetricRatioInput(
            global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile> numerator,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile> denominator,
            string type = "ratio")
        {
            this.Type = type;
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricRatioInput" /> class.
        /// </summary>
        public CustomChartMetricRatioInput()
        {
        }

    }
}