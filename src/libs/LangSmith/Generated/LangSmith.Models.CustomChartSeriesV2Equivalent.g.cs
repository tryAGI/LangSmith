
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A V1 series' translated V2 equivalent, for display only — does not<br/>
    /// mean the series itself has been migrated.<br/>
    /// Kept separate from metric_definition/group_by_definitions/<br/>
    /// filter_definition, since merging would violate CustomChartSeriesBase's<br/>
    /// exactly-one-of-metric-or-metric_definition invariant for V1 series.
    /// </summary>
    public sealed partial class CustomChartSeriesV2Equivalent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_definition")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnyOfJsonConverter<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>))]
        public global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>? MetricDefinition { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesV2Equivalent" /> class.
        /// </summary>
        /// <param name="metricDefinition"></param>
        /// <param name="groupByDefinitions"></param>
        /// <param name="filterDefinition"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomChartSeriesV2Equivalent(
            global::LangSmith.AnyOf<global::LangSmith.CustomChartFeedbackCountMetric, global::LangSmith.CustomChartMetricCount, global::LangSmith.CustomChartFeedbackScoreMetricScalar, global::LangSmith.CustomChartMetricScalar, global::LangSmith.CustomChartFeedbackScoreMetricPercentile, global::LangSmith.CustomChartMetricPercentile, global::LangSmith.CustomChartMetricRatioOutput, object>? metricDefinition,
            global::System.Collections.Generic.IList<global::LangSmith.AnyOf<global::LangSmith.CustomChartGroupByPlain, global::LangSmith.CustomChartGroupByComplex>>? groupByDefinitions,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartFilterByTracingProject, global::LangSmith.CustomChartFilterByDataset, object>? filterDefinition)
        {
            this.MetricDefinition = metricDefinition;
            this.GroupByDefinitions = groupByDefinitions;
            this.FilterDefinition = filterDefinition;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomChartSeriesV2Equivalent" /> class.
        /// </summary>
        public CustomChartSeriesV2Equivalent()
        {
        }

    }
}