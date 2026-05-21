
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Add run to AQ by SmithDB key. is_root derived server-side (LSAQ-141).
    /// </summary>
    public sealed partial class AddRunToQueueByKeyRequest
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
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_proposed_example_id")]
        public global::System.Guid? SourceProposedExampleId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRunToQueueByKeyRequest" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="startTime"></param>
        /// <param name="sourceProposedExampleId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AddRunToQueueByKeyRequest(
            global::System.Guid runId,
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            global::System.Guid? sourceProposedExampleId)
        {
            this.RunId = runId;
            this.SessionId = sessionId;
            this.StartTime = startTime;
            this.SourceProposedExampleId = sourceProposedExampleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddRunToQueueByKeyRequest" /> class.
        /// </summary>
        public AddRunToQueueByKeyRequest()
        {
        }

    }
}