
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        public string? AddedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? ItemType { get; set; }

        /// <summary>
        /// LastReviewedTime is always present on the wire (null until reviewed).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_reviewed_time")]
        public string? LastReviewedTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queue_id")]
        public string? QueueId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_proposed_example_id")]
        public string? SourceProposedExampleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public string? StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread_id")]
        public string? ThreadId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItem" /> class.
        /// </summary>
        /// <param name="addedAt"></param>
        /// <param name="id"></param>
        /// <param name="itemType"></param>
        /// <param name="lastReviewedTime">
        /// LastReviewedTime is always present on the wire (null until reviewed).
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="queueId"></param>
        /// <param name="runId"></param>
        /// <param name="sourceProposedExampleId"></param>
        /// <param name="startTime"></param>
        /// <param name="threadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueItem(
            string? addedAt,
            string? id,
            global::LangSmith.AnnotationqueuesAnnotationQueueItemType? itemType,
            string? lastReviewedTime,
            string? projectId,
            string? queueId,
            string? runId,
            string? sourceProposedExampleId,
            string? startTime,
            string? threadId)
        {
            this.AddedAt = addedAt;
            this.Id = id;
            this.ItemType = itemType;
            this.LastReviewedTime = lastReviewedTime;
            this.ProjectId = projectId;
            this.QueueId = queueId;
            this.RunId = runId;
            this.SourceProposedExampleId = sourceProposedExampleId;
            this.StartTime = startTime;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItem" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueItem()
        {
        }

    }
}