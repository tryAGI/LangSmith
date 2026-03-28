
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartUpdate
    {
        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Title { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<string, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? Description { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<int?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Index { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartType?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? ChartType { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Series { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, global::LangSmith.Missing>))]
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? SectionId { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<object, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? Metadata { get; set; }

        /// <summary>
        /// Default Value: {"__missing__":"__missing__"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="chartType">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="series">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="sectionId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="commonFilters">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? sectionId,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? metadata,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>? commonFilters)
        {
            this.Title = title;
            this.Description = description;
            this.Index = index;
            this.ChartType = chartType;
            this.Series = series;
            this.SectionId = sectionId;
            this.Metadata = metadata;
            this.CommonFilters = commonFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        public CustomChartUpdate()
        {
        }
    }
}