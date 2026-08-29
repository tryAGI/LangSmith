
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CustomChartsSectionChartDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CustomChartsSectionChartDiscriminatorChartTypeJsonConverter))]
        public global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? ChartType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionChartDiscriminator" /> class.
        /// </summary>
        /// <param name="chartType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartsSectionChartDiscriminator(
            global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? chartType)
        {
            this.ChartType = chartType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartsSectionChartDiscriminator" /> class.
        /// </summary>
        public CustomChartsSectionChartDiscriminator()
        {
        }

    }
}