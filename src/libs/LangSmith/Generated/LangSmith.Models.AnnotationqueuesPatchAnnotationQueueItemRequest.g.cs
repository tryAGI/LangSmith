
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesPatchAnnotationQueueItemRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public global::System.DateTime? AddedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public global::System.DateTime? LastReviewedTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesPatchAnnotationQueueItemRequest" /> class.
        /// </summary>
        /// <param name="addedAt"></param>
        /// <param name="lastReviewedTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesPatchAnnotationQueueItemRequest(
            global::System.DateTime? addedAt,
            global::System.DateTime? lastReviewedTime)
        {
            this.AddedAt = addedAt;
            this.LastReviewedTime = lastReviewedTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesPatchAnnotationQueueItemRequest" /> class.
        /// </summary>
        public AnnotationqueuesPatchAnnotationQueueItemRequest()
        {
        }

    }
}