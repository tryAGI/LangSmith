
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesListAnnotationQueueItemsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_cursor")]
        public string? PreviousCursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesListAnnotationQueueItemsResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
        /// <param name="previousCursor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesListAnnotationQueueItemsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.AnnotationqueuesAnnotationQueueListItem>? items,
            string? nextCursor,
            string? previousCursor)
        {
            this.Items = items;
            this.NextCursor = nextCursor;
            this.PreviousCursor = previousCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesListAnnotationQueueItemsResponse" /> class.
        /// </summary>
        public AnnotationqueuesListAnnotationQueueItemsResponse()
        {
        }

    }
}