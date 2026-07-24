
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartMetricCount
    {
        /// <summary>
        /// Default Value: count
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public string? Filter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricCount" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: count
        /// </param>
        /// <param name="filter"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartMetricCount(
            string? type,
            string? filter)
        {
            this.Type = type;
            this.Filter = filter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartMetricCount" /> class.
        /// </summary>
        public CustomChartMetricCount()
        {
        }

    }
}