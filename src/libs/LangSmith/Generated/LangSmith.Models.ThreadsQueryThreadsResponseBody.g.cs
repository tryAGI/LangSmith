
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsQueryThreadsResponseBody
    {
        /// <summary>
        /// `has_more` is true when another page of threads exists after this one.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// `items` is the page of thread summaries, sorted by the thread's most recent activity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? Items { get; set; }

        /// <summary>
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request when `has_more` is true. Omitted on the final page.<br/>
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
        /// <param name="hasMore">
        /// `has_more` is true when another page of threads exists after this one.<br/>
        /// Example: true
        /// </param>
        /// <param name="items">
        /// `items` is the page of thread summaries, sorted by the thread's most recent activity.
        /// </param>
        /// <param name="nextCursor">
        /// `next_cursor` is the opaque cursor to pass as `cursor` on the next request when `has_more` is true. Omitted on the final page.<br/>
        /// Example: eyJydW5zX2N1cnNvciI6Imx0KGN1cnNvciwiLi4uIikifQ==
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsQueryThreadsResponseBody(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsThreadListItem>? items,
            string? nextCursor)
        {
            this.HasMore = hasMore;
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