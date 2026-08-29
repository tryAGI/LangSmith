
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesCreateAnnotationQueueItemStatusRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("override_added_at")]
        public string? OverrideAddedAt { get; set; }

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
        /// Initializes a new instance of the <see cref="AnnotationqueuesCreateAnnotationQueueItemStatusRequest" /> class.
        /// </summary>
        /// <param name="overrideAddedAt"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesCreateAnnotationQueueItemStatusRequest(
            string? overrideAddedAt,
            global::LangSmith.AnnotationqueuesAnnotationQueueReviewStatus? status)
        {
            this.OverrideAddedAt = overrideAddedAt;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesCreateAnnotationQueueItemStatusRequest" /> class.
        /// </summary>
        public AnnotationqueuesCreateAnnotationQueueItemStatusRequest()
        {
        }

    }
}