
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartMetricPercentile
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
        [global::System.Text.Json.Serialization.JsonPropertyName("field")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CustomChartMetricFieldJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.CustomChartMetricField Field { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("params")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.CustomChartMetricPercentileParams Params { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricPercentile" /> class.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="params"></param>
        /// <param name="filter"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartMetricPercentile(
            global::LangSmith.CustomChartMetricField field,
            global::LangSmith.CustomChartMetricPercentileParams @params,
            string? filter,
            string type = "percentile")
        {
            this.Type = type;
            this.Filter = filter;
            this.Field = field;
            this.Params = @params ?? throw new global::System.ArgumentNullException(nameof(@params));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricPercentile" /> class.
        /// </summary>
        public CustomChartMetricPercentile()
        {
        }

    }
}