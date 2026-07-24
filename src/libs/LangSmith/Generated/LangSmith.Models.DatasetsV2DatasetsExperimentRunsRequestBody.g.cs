
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetsV2DatasetsExperimentRunsRequestBody
    {
        /// <summary>
        /// `comparative_experiment_id` scopes pairwise-annotation feedback (optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("comparative_experiment_id")]
        public string? ComparativeExperimentId { get; set; }

        /// <summary>
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Absent for the first page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// `example_ids` optionally restricts the page to these dataset example UUIDs (max 1000).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_ids")]
        public global::System.Collections.Generic.IList<string>? ExampleIds { get; set; }

        /// <summary>
        /// `experiment_ids` lists the experiment (tracing session) UUIDs to query. Required, non-empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("experiment_ids")]
        public global::System.Collections.Generic.IList<string>? ExperimentIds { get; set; }

        /// <summary>
        /// `filters` maps a project (session) UUID string to a list of filter expressions (optional).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? Filters { get; set; }

        /// <summary>
        /// `page_size` is the maximum number of examples to return. Defaults to 20, max 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// `selects` lists which run properties to include. Omitted =&gt; only `id`. Tokens mirror /v2/runs/query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selects")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? Selects { get; set; }

        /// <summary>
        /// `sort` controls feedback-score sorting (single project only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sort")]
        public global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? Sort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsRequestBody" /> class.
        /// </summary>
        /// <param name="comparativeExperimentId">
        /// `comparative_experiment_id` scopes pairwise-annotation feedback (optional).
        /// </param>
        /// <param name="cursor">
        /// `cursor` is the opaque string from a previous response's `next_cursor`. Absent for the first page.
        /// </param>
        /// <param name="exampleIds">
        /// `example_ids` optionally restricts the page to these dataset example UUIDs (max 1000).
        /// </param>
        /// <param name="experimentIds">
        /// `experiment_ids` lists the experiment (tracing session) UUIDs to query. Required, non-empty.
        /// </param>
        /// <param name="filters">
        /// `filters` maps a project (session) UUID string to a list of filter expressions (optional).
        /// </param>
        /// <param name="pageSize">
        /// `page_size` is the maximum number of examples to return. Defaults to 20, max 100.
        /// </param>
        /// <param name="selects">
        /// `selects` lists which run properties to include. Omitted =&gt; only `id`. Tokens mirror /v2/runs/query.
        /// </param>
        /// <param name="sort">
        /// `sort` controls feedback-score sorting (single project only).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DatasetsV2DatasetsExperimentRunsRequestBody(
            string? comparativeExperimentId,
            string? cursor,
            global::System.Collections.Generic.IList<string>? exampleIds,
            global::System.Collections.Generic.IList<string>? experimentIds,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters,
            int? pageSize,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunSelectField>? selects,
            global::LangSmith.DatasetsV2DatasetsExperimentRunsSort? sort)
        {
            this.ComparativeExperimentId = comparativeExperimentId;
            this.Cursor = cursor;
            this.ExampleIds = exampleIds;
            this.ExperimentIds = experimentIds;
            this.Filters = filters;
            this.PageSize = pageSize;
            this.Selects = selects;
            this.Sort = sort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetsV2DatasetsExperimentRunsRequestBody" /> class.
        /// </summary>
        public DatasetsV2DatasetsExperimentRunsRequestBody()
        {
        }

    }
}