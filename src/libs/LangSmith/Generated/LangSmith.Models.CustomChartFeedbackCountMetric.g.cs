
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomChartFeedbackCountMetric
    {
        /// <summary>
        /// Default Value: count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"feedback"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity")]
        public string Entity { get; set; } = "feedback";

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
        public required global::LangSmith.CustomChartFeedbackCountMetricParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackCountMetric" /> class.
        /// </summary>
        /// <param name="params"></param>
        /// <param name="type">
        /// Default Value: count
        /// </param>
        /// <param name="filter"></param>
        /// <param name="entity"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartFeedbackCountMetric(
            global::LangSmith.CustomChartFeedbackCountMetricParams @params,
            string? type,
            string? filter,
            string entity = "feedback")
        {
            this.Type = type;
            this.Entity = entity;
            this.Filter = filter;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartFeedbackCountMetric" /> class.
        /// </summary>
        public CustomChartFeedbackCountMetric()
        {
        }

        /// <summary>
        /// Creates a new <see cref="CustomChartFeedbackCountMetric"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static CustomChartFeedbackCountMetric FromParams(global::LangSmith.CustomChartFeedbackCountMetricParams @params)
        {
            return new CustomChartFeedbackCountMetric
            {
                Params = @params,
            };
        }

    }
}