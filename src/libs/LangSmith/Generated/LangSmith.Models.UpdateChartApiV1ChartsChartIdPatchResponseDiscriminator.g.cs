
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartTypeJsonConverter))]
        public global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? ChartType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="chartType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator(
            global::LangSmith.UpdateChartApiV1ChartsChartIdPatchResponseDiscriminatorChartType? chartType)
        {
            this.ChartType = chartType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator" /> class.
        /// </summary>
        public UpdateChartApiV1ChartsChartIdPatchResponseDiscriminator()
        {
        }

    }
}