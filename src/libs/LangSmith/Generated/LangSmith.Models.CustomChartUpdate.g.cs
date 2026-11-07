
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
        public string? Title { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Enum for custom chart types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CustomChartTypeJsonConverter))]
        public global::LangSmith.CustomChartType? ChartType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        public global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? Series { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section_id")]
        public global::System.Guid? SectionId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_filters")]
        public global::LangSmith.CustomChartSeriesFilters? CommonFilters { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("markdown")]
        public string? Markdown { get; set; }

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
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="markdown"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartUpdate(
            string? title,
            string? description,
            int? index,
            global::LangSmith.CustomChartType? chartType,
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>? series,
            global::System.Guid? sectionId,
            object? metadata,
            global::LangSmith.CustomChartSeriesFilters? commonFilters,
            string? markdown)
        {
            this.Title = title;
            this.Description = description;
            this.Index = index;
            this.ChartType = chartType;
            this.Series = series;
            this.SectionId = sectionId;
            this.Metadata = metadata;
            this.CommonFilters = commonFilters;
            this.Markdown = markdown;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartUpdate" /> class.
        /// </summary>
        public CustomChartUpdate()
        {
        }

    }
}