
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnnotationqueuesAnnotationQueueItemInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AnnotationqueuesAnnotationQueueItemTypeJsonConverter))]
        public global::LangSmith.AnnotationqueuesAnnotationQueueItemType? ItemType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// RUN fields
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        public string? RunId { get; set; }

        /// <summary>
        /// SessionID is an alias for project_id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// SourceProposedExampleID links the queue item to the suggested example<br/>
        /// it was created from, when applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_proposed_example_id")]
        public string? SourceProposedExampleId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

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
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemInput" /> class.
        /// </summary>
        /// <param name="itemType"></param>
        /// <param name="projectId"></param>
        /// <param name="runId">
        /// RUN fields
        /// </param>
        /// <param name="sessionId">
        /// SessionID is an alias for project_id.
        /// </param>
        /// <param name="sourceProposedExampleId">
        /// SourceProposedExampleID links the queue item to the suggested example<br/>
        /// it was created from, when applicable.
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="threadId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationqueuesAnnotationQueueItemInput(
            global::LangSmith.AnnotationqueuesAnnotationQueueItemType? itemType,
            string? projectId,
            string? runId,
            string? sessionId,
            string? sourceProposedExampleId,
            global::System.DateTime? startTime,
            string? threadId)
        {
            this.ItemType = itemType;
            this.ProjectId = projectId;
            this.RunId = runId;
            this.SessionId = sessionId;
            this.SourceProposedExampleId = sourceProposedExampleId;
            this.StartTime = startTime;
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationqueuesAnnotationQueueItemInput" /> class.
        /// </summary>
        public AnnotationqueuesAnnotationQueueItemInput()
        {
        }

    }
}