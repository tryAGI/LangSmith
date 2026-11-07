
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SqlqueryQueryRequest
    {
        /// <summary>
        /// ProjectIDs are the tracing projects the query can read.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ProjectIds { get; set; }

        /// <summary>
        /// Query is a single read-only SQL statement. Queries over runs need a start_time lower bound.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryQueryRequest" /> class.
        /// </summary>
        /// <param name="projectIds">
        /// ProjectIDs are the tracing projects the query can read.
        /// </param>
        /// <param name="query">
        /// Query is a single read-only SQL statement. Queries over runs need a start_time lower bound.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SqlqueryQueryRequest(
            global::System.Collections.Generic.IList<global::System.Guid> projectIds,
            string query)
        {
            this.ProjectIds = projectIds ?? throw new global::System.ArgumentNullException(nameof(projectIds));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryQueryRequest" /> class.
        /// </summary>
        public SqlqueryQueryRequest()
        {
        }

    }
}