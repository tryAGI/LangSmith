
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteRunsApiV1RunsDeletePost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? TraceIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_examples")]
        public bool? DeleteExamples { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        public global::System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsApiV1RunsDeletePost" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        /// <param name="metadata"></param>
        /// <param name="deleteExamples">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteRunsApiV1RunsDeletePost(
            global::System.Guid? sessionId,
            global::System.Collections.Generic.IList<global::System.Guid>? traceIds,
            object? metadata,
            bool? deleteExamples,
            global::System.DateTime? startTime)
        {
            this.SessionId = sessionId;
            this.TraceIds = traceIds;
            this.Metadata = metadata;
            this.DeleteExamples = deleteExamples;
            this.StartTime = startTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsApiV1RunsDeletePost" /> class.
        /// </summary>
        public BodyDeleteRunsApiV1RunsDeletePost()
        {
        }

    }
}