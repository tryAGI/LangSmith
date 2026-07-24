
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryThreadsResponseBody
    {
        /// <summary>
        /// `items` is the page of thread summaries, sorted by the thread's most recent activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Items { get; set; }

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
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsResponseBody" /> class.
        /// </summary>
        /// <param name="items">
        /// `items` is the page of thread summaries, sorted by the thread's most recent activity.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request. Null on the final page.<br/>
        /// Example: eyJydW5zX2N1cnNvciI6Imx0KGN1cnNvciwiLi4uIikifQ==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadsResponseBody(
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? items,
            string? nextCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsQueryThreadsResponseBody" /> class.
        /// </summary>
        public ThreadsQueryThreadsResponseBody()
        {
        }

    }
}