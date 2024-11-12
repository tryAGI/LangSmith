
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<string, global::LangSmith.Missing>? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? Index { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? ChartType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? SectionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<object, global::LangSmith.Missing>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_filters")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverterFactory2))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType"></param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CustomChartUpdate(
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? sectionId,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? commonFilters)
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