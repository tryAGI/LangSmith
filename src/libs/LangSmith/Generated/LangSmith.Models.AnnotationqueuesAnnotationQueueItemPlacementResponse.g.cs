
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueItemPlacementResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? ItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("position")]
        public int? Position { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("section")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemListStatusJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? Section { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemPlacementResponse" /> class.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="itemType"></param>
        /// <param name="position"></param>
        /// <param name="section"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueItemPlacementResponse(
            string? cursor,
            global::LangSmith.AnnotationqueuesAnnotationQueueItemType? itemType,
            int? position,
            global::LangSmith.AnnotationqueuesAnnotationQueueItemListStatus? section)
        {
            this.Cursor = cursor;
            this.ItemType = itemType;
            this.Position = position;
            this.Section = section;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemPlacementResponse" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueItemPlacementResponse()
        {
        }

    }
}