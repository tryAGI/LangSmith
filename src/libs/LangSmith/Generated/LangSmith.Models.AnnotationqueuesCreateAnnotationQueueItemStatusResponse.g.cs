
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesCreateAnnotationQueueItemStatusResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_archived")]
        public bool? IsArchived { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_added_at")]
        public string? OverrideAddedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_item_id")]
        public string? QueueItemId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueReviewStatusJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesCreateAnnotationQueueItemStatusResponse" /> class.
        /// </summary>
        /// <param name="isArchived"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="queueItemId"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesCreateAnnotationQueueItemStatusResponse(
            bool? isArchived,
            string? overrideAddedAt,
            string? queueItemId,
            global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? status)
        {
            this.IsArchived = isArchived;
            this.OverrideAddedAt = overrideAddedAt;
            this.QueueItemId = queueItemId;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesCreateAnnotationQueueItemStatusResponse" /> class.
        /// </summary>
        public AnnotationqueuesCreateAnnotationQueueItemStatusResponse()
        {
        }

    }
}