
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomChartSeriesUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::LangSmith.CustomChartSeriesFilters? Filters { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public global::LangSmith.CustomChartMetric? Metric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_metric")]
        public global::LangSmith.HostProjectChartMetric? ProjectMetric { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("feedback_key")]
        public string? FeedbackKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public global::System.Guid? WorkspaceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>? MetricDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by_definitions")]
        public global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? GroupByDefinitions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>? FilterDefinition { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::LangSmith.RunStatsGroupBy? GroupBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesUpdate" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metadata"></param>
        /// <param name="filters"></param>
        /// <param name="metric"></param>
        /// <param name="projectMetric"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="workspaceId"></param>
        /// <param name="metricDefinition"></param>
        /// <param name="groupByDefinitions"></param>
        /// <param name="filterDefinition"></param>
        /// <param name="groupBy"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartSeriesUpdate(
            string name,
            object? metadata,
            global::LangSmith.CustomChartSeriesFilters? filters,
            global::LangSmith.CustomChartMetric? metric,
            global::LangSmith.HostProjectChartMetric? projectMetric,
            string? feedbackKey,
            global::System.Guid? workspaceId,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioInput, object>? metricDefinition,
            global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? groupByDefinitions,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>? filterDefinition,
            global::LangSmith.RunStatsGroupBy? groupBy,
            global::System.Guid? id)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Metadata = metadata;
            this.Filters = filters;
            this.Metric = metric;
            this.ProjectMetric = projectMetric;
            this.FeedbackKey = feedbackKey;
            this.WorkspaceId = workspaceId;
            this.MetricDefinition = metricDefinition;
            this.GroupByDefinitions = groupByDefinitions;
            this.FilterDefinition = filterDefinition;
            this.GroupBy = groupBy;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesUpdate" /> class.
        /// </summary>
        public CustomChartSeriesUpdate()
        {
        }

    }
}