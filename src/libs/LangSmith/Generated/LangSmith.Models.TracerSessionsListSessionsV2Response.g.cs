
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TracerSessionsListSessionsV2Response
    {
        /// <summary>
        /// Tracing projects on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.Session> Items { get; set; }

        /// <summary>
        /// Pass as cursor to fetch the next page. Null on the last page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsListSessionsV2Response" /> class.
        /// </summary>
        /// <param name="items">
        /// Tracing projects on this page.
        /// </param>
        /// <param name="nextCursor">
        /// Pass as cursor to fetch the next page. Null on the last page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionsListSessionsV2Response(
            global::System.Collections.Generic.IList<global::LangSmith.Session> items,
            string? nextCursor)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionsListSessionsV2Response" /> class.
        /// </summary>
        public TracerSessionsListSessionsV2Response()
        {
        }

    }
}