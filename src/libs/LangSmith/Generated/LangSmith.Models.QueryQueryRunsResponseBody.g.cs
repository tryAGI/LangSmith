
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryRunsResponseBody
    {
        /// <summary>
        /// `items` is the page of runs, sorted by `start_time` descending.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Items { get; set; }

        /// <summary>
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request. Null on the final page.<br/>
        /// Example: eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ
        /// </summary>
        /// <example>eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryRunsResponseBody" /> class.
        /// </summary>
        /// <param name="items">
        /// `items` is the page of runs, sorted by `start_time` descending.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request. Null on the final page.<br/>
        /// Example: eyJ2IjoxLCJhIjoicnVucy5xdWVyeSIsImsiOiJwYXNzIiwiYiI6InNkYiIsInQiOiJsdChjdXJzb3IsICcyMDI1LTEyLTEyIDE5OjAzOjI4LjQ4MTI1NTAxOWIxM2YyJykifQ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryRunsResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryRunsResponseBody" /> class.
        /// </summary>
        public QueryQueryRunsResponseBody()
        {
        }

    }
}