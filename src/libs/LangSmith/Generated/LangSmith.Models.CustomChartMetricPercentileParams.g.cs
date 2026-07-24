
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartMetricPercentileParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("p")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double P { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricPercentileParams" /> class.
        /// </summary>
        /// <param name="p"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartMetricPercentileParams(
            double p)
        {
            this.P = p;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricPercentileParams" /> class.
        /// </summary>
        public CustomChartMetricPercentileParams()
        {
        }

    }
}