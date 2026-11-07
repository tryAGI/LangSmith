
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SqlqueryQueryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("columns")]
        public global::System.Collections.Generic.IList<global::LangSmith.SqlqueryColumn>? Columns { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("execution_time_ms")]
        public double? ExecutionTimeMs { get; set; }

        /// <summary>
        /// IsTruncated reports that the query matched rows not included in Rows.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_truncated")]
        public bool? IsTruncated { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("row_count")]
        public int? RowCount { get; set; }

        /// <summary>
        /// Rows holds at most the configured row limit (1000 by default), each<br/>
        /// ordered like Columns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rows")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? Rows { get; set; }

        /// <summary>
        /// TruncationReason is "row_limit" when the query matched more rows than<br/>
        /// the row limit, "size_limit" when the rows past about 10 MB were left out,<br/>
        /// or null.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("truncation_reason")]
        public global::LangSmith.SqlqueryQueryResponseTruncationReason? TruncationReason { get; set; }

        /// <summary>
        /// Warnings contains query planning warnings. Empty when there are no warnings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("warnings")]
        public global::System.Collections.Generic.IList<string>? Warnings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryQueryResponse" /> class.
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="executionTimeMs"></param>
        /// <param name="isTruncated">
        /// IsTruncated reports that the query matched rows not included in Rows.
        /// </param>
        /// <param name="rowCount"></param>
        /// <param name="rows">
        /// Rows holds at most the configured row limit (1000 by default), each<br/>
        /// ordered like Columns.
        /// </param>
        /// <param name="truncationReason">
        /// TruncationReason is "row_limit" when the query matched more rows than<br/>
        /// the row limit, "size_limit" when the rows past about 10 MB were left out,<br/>
        /// or null.
        /// </param>
        /// <param name="warnings">
        /// Warnings contains query planning warnings. Empty when there are no warnings.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SqlqueryQueryResponse(
            global::System.Collections.Generic.IList<global::LangSmith.SqlqueryColumn>? columns,
            double? executionTimeMs,
            bool? isTruncated,
            int? rowCount,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? rows,
            global::LangSmith.SqlqueryQueryResponseTruncationReason? truncationReason,
            global::System.Collections.Generic.IList<string>? warnings)
        {
            this.Columns = columns;
            this.ExecutionTimeMs = executionTimeMs;
            this.IsTruncated = isTruncated;
            this.RowCount = rowCount;
            this.Rows = rows;
            this.TruncationReason = truncationReason;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryQueryResponse" /> class.
        /// </summary>
        public SqlqueryQueryResponse()
        {
        }

    }
}