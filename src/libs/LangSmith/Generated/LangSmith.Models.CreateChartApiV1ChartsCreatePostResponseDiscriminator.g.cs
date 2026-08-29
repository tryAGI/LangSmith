
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateChartApiV1ChartsCreatePostResponseDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeJsonConverter))]
        public global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? ChartType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChartApiV1ChartsCreatePostResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="chartType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChartApiV1ChartsCreatePostResponseDiscriminator(
            global::LangSmith.CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? chartType)
        {
            this.ChartType = chartType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChartApiV1ChartsCreatePostResponseDiscriminator" /> class.
        /// </summary>
        public CreateChartApiV1ChartsCreatePostResponseDiscriminator()
        {
        }

    }
}