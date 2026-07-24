
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QueryQueryTracesResponseBody
    {
        /// <summary>
        /// `items` is the page of traces.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? Items { get; set; }

        /// <summary>
        /// `next_cursor` is the opaque cursor for the next page. Null on the final page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryTracesResponseBody" /> class.
        /// </summary>
        /// <param name="items">
        /// `items` is the page of traces.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor for the next page. Null on the final page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryQueryTracesResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.QueryTrace>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryQueryTracesResponseBody" /> class.
        /// </summary>
        public QueryQueryTracesResponseBody()
        {
        }

    }
}