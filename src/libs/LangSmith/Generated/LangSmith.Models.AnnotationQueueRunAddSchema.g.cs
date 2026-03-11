
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Schema for adding a run to an annotation queue with optional metadata.
    /// </summary>
    public sealed partial class AnnotationQueueRunAddSchema
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_run_id")]
        public global::System.Guid? ParentRunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_tier")]
        public global::LangSmith.TraceTier? TraceTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunAddSchema" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="startTime"></param>
        /// <param name="sessionId"></param>
        /// <param name="traceId"></param>
        /// <param name="parentRunId"></param>
        /// <param name="traceTier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnnotationQueueRunAddSchema(
            global::System.Guid runId,
            global::System.DateTime? startTime,
            global::System.Guid? sessionId,
            global::System.Guid? traceId,
            global::System.Guid? parentRunId,
            global::LangSmith.TraceTier? traceTier)
        {
            this.RunId = runId;
            this.StartTime = startTime;
            this.SessionId = sessionId;
            this.TraceId = traceId;
            this.ParentRunId = parentRunId;
            this.TraceTier = traceTier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationQueueRunAddSchema" /> class.
        /// </summary>
        public AnnotationQueueRunAddSchema()
        {
        }
    }
}