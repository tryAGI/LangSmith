
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryExampleSchemaWithRuns
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> SessionIds { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Default Value: 10
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryExampleSchemaWithRunsFormatJsonConverter))]
        public global::LangSmith.QueryExampleSchemaWithRunsFormat? Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public global::System.Guid? ComparativeExperimentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort_params")]
        public global::LangSmith.SortParamsForRunsComparisonView? SortParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="format"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="sortParams"></param>
        /// <param name="filters"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryExampleSchemaWithRuns(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            int? offset,
            int? limit,
            bool? preview,
            global::LangSmith.QueryExampleSchemaWithRunsFormat? format,
            global::System.Guid? comparativeExperimentId,
            global::LangSmith.SortParamsForRunsComparisonView? sortParams,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.Offset = offset;
            this.Limit = limit;
            this.Preview = preview;
            this.Format = format;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.SortParams = sortParams;
            this.Filters = filters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRuns" /> class.
        /// </summary>
        public QueryExampleSchemaWithRuns()
        {
        }
    }
}