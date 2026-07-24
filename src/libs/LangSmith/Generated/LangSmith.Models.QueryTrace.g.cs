
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryTrace
    {
        /// <summary>
        /// `root_run` is the trace's root run. Which properties are populated is controlled by `selects` in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("root_run")]
        public global::LangSmith.QueryRunResponse? RootRun { get; set; }

        /// <summary>
        /// `trace_aggregates` carries trace-wide aggregate metrics. Omitted when no aggregate field was selected, or `null` (then later filled) on the streaming wire while the aggregate values are still being computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_aggregates")]
        public global::LangSmith.QueryTraceAggregates? TraceAggregates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTrace" /> class.
        /// </summary>
        /// <param name="rootRun">
        /// `root_run` is the trace's root run. Which properties are populated is controlled by `selects` in the request.
        /// </param>
        /// <param name="traceAggregates">
        /// `trace_aggregates` carries trace-wide aggregate metrics. Omitted when no aggregate field was selected, or `null` (then later filled) on the streaming wire while the aggregate values are still being computed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryTrace(
            global::LangSmith.QueryRunResponse? rootRun,
            global::LangSmith.QueryTraceAggregates? traceAggregates)
        {
            this.RootRun = rootRun;
            this.TraceAggregates = traceAggregates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryTrace" /> class.
        /// </summary>
        public QueryTrace()
        {
        }

    }
}