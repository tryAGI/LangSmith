
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryThreadTracesResponseBody
    {
        /// <summary>
        /// `items` is the page of root traces in this thread. Which properties are populated on each trace depends on the `selects` query parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? Items { get; set; }

        /// <summary>
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request. Null on the final page.<br/>
        /// Example: eyJydW5zX2N1cnNvciI6Imx0KGN1cnNvciwiLi4uIikifQ==
        /// </summary>
        /// <example>eyJydW5zX2N1cnNvciI6Imx0KGN1cnNvciwiLi4uIikifQ==</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadTracesResponseBody" /> class.
        /// </summary>
        /// <param name="items">
        /// `items` is the page of root traces in this thread. Which properties are populated on each trace depends on the `selects` query parameter.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request. Null on the final page.<br/>
        /// Example: eyJydW5zX2N1cnNvciI6Imx0KGN1cnNvciwiLi4uIikifQ==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadTracesResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadTraceListItem>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadTracesResponseBody" /> class.
        /// </summary>
        public ThreadsQueryThreadTracesResponseBody()
        {
        }

    }
}