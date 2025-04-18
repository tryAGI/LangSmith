
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SingleCustomChartResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint> Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::System.Guid?, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.AnyOf<global::System.Guid?, string> Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("title")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Title { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Enum for custom chart types.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chart_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CustomChartTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.CustomChartType ChartType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("series")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries> Series { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("common_filters")]
        public global::LangSmith.CustomChartSeriesFilters? CommonFilters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="metadata"></param>
        /// <param name="index"></param>
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="commonFilters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SingleCustomChartResponse(
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartsDataPoint> data,
            global::LangSmith.AnyOf<global::System.Guid?, string> id,
            string title,
            int index,
            global::LangSmith.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeries> series,
            string? description,
            object? metadata,
            global::LangSmith.CustomChartSeriesFilters? commonFilters)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Id = id;
            this.Title = title ?? throw new global::System.ArgumentNullException(nameof(title));
            this.Index = index;
            this.ChartType = chartType;
            this.Series = series ?? throw new global::System.ArgumentNullException(nameof(series));
            this.Description = description;
            this.Metadata = metadata;
            this.CommonFilters = commonFilters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SingleCustomChartResponse" /> class.
        /// </summary>
        public SingleCustomChartResponse()
        {
        }
    }
}