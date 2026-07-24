
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartFeedbackScoreMetricScalar
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <default>"feedback_score"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        public string Field { get; set; } = "feedback_score";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.CustomChartFeedbackScoreMetricScalarParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricScalar" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="params"></param>
        /// <param name="filter"></param>
        /// <param name="field"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFeedbackScoreMetricScalar(
            string type,
            global::LangSmith.CustomChartFeedbackScoreMetricScalarParams @params,
            string? filter,
            string field = "feedback_score")
        {
            this.Type = type;
            this.Field = field;
            this.Filter = filter;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackScoreMetricScalar" /> class.
        /// </summary>
        public CustomChartFeedbackScoreMetricScalar()
        {
        }

    }
}