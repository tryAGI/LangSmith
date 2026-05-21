
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryRunsResponseBody
    {
        /// <summary>
        /// `has_more` is true when another page of runs exists after this one.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// `items` is the page of runs, sorted by `start_time` in the direction given by the request `sort_order`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? Items { get; set; }

        /// <summary>
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request when `has_more` is true. Omitted on the final page.<br/>
        /// Example: eyJsYXN0X2lkIjoiMDE4ZTRjN2UtYTlmYi03ZWYwLWE1YjYtNmVhM2E4MmU5MzI3In0=
        /// </summary>
        /// <example>eyJsYXN0X2lkIjoiMDE4ZTRjN2UtYTlmYi03ZWYwLWE1YjYtNmVhM2E4MmU5MzI3In0=</example>
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
        /// <param name="hasMore">
        /// `has_more` is true when another page of runs exists after this one.<br/>
        /// Example: true
        /// </param>
        /// <param name="items">
        /// `items` is the page of runs, sorted by `start_time` in the direction given by the request `sort_order`.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request when `has_more` is true. Omitted on the final page.<br/>
        /// Example: eyJsYXN0X2lkIjoiMDE4ZTRjN2UtYTlmYi03ZWYwLWE1YjYtNmVhM2E4MmU5MzI3In0=
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryRunsResponseBody(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::LangSmith.QueryRunResponse>? items,
            string? nextCursor)
        {
            this.HasMore = hasMore;
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