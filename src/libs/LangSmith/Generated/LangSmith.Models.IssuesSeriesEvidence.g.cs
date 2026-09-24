
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesSeriesEvidence
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric_definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RunsanalyticsMetricDefinition MetricDefinition { get; set; }

        /// <summary>
        /// Narrows what is measured; the renderer ANDs its root scope over it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_filter")]
        public string? RunFilter { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_end")]
        public global::System.DateTime? WindowEnd { get; set; }

        /// <summary>
        /// The view the chart opens at, not a clamp. Start alone renders start -&gt; now.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("window_start")]
        public global::System.DateTime? WindowStart { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSeriesEvidence" /> class.
        /// </summary>
        /// <param name="metricDefinition"></param>
        /// <param name="runFilter">
        /// Narrows what is measured; the renderer ANDs its root scope over it.
        /// </param>
        /// <param name="windowEnd"></param>
        /// <param name="windowStart">
        /// The view the chart opens at, not a clamp. Start alone renders start -&gt; now.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesSeriesEvidence(
            global::LangSmith.RunsanalyticsMetricDefinition metricDefinition,
            string? runFilter,
            global::System.DateTime? windowEnd,
            global::System.DateTime? windowStart)
        {
            this.MetricDefinition = metricDefinition ?? throw new global::System.ArgumentNullException(nameof(metricDefinition));
            this.RunFilter = runFilter;
            this.WindowEnd = windowEnd;
            this.WindowStart = windowStart;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesSeriesEvidence" /> class.
        /// </summary>
        public IssuesSeriesEvidence()
        {
        }

    }
}