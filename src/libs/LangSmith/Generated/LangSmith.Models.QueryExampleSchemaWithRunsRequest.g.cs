
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request DTO for querying examples with runs - used for API input.<br/>
    /// This is separate from the internal schema to cleanly handle optional limit values.<br/>
    /// When limit is None, the internal schema will apply appropriate defaults based on<br/>
    /// format.
    /// </summary>
    public sealed partial class QueryExampleSchemaWithRunsRequest
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
        /// 
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleIds { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_annotator_detail")]
        public bool? IncludeAnnotatorDetail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRunsRequest" /> class.
        /// </summary>
        /// <param name="sessionIds"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit"></param>
        /// <param name="preview">
        /// Default Value: false
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="sortParams"></param>
        /// <param name="filters"></param>
        /// <param name="exampleIds"></param>
        /// <param name="includeAnnotatorDetail">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryExampleSchemaWithRunsRequest(
            global::System.Collections.Generic.IList<global::System.Guid> sessionIds,
            int? offset,
            int? limit,
            bool? preview,
            global::System.Guid? comparativeExperimentId,
            global::LangSmith.SortParamsForRunsComparisonView? sortParams,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleIds,
            bool? includeAnnotatorDetail)
        {
            this.SessionIds = sessionIds ?? throw new global::System.ArgumentNullException(nameof(sessionIds));
            this.Offset = offset;
            this.Limit = limit;
            this.Preview = preview;
            this.ComparativeExperimentId = comparativeExperimentId;
            this.SortParams = sortParams;
            this.Filters = filters;
            this.ExampleIds = exampleIds;
            this.IncludeAnnotatorDetail = includeAnnotatorDetail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryExampleSchemaWithRunsRequest" /> class.
        /// </summary>
        public QueryExampleSchemaWithRunsRequest()
        {
        }
    }
}