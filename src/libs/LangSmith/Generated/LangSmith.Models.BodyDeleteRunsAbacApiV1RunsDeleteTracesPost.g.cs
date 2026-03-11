
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyDeleteRunsAbacApiV1RunsDeleteTracesPost
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid SessionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> TraceIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsAbacApiV1RunsDeleteTracesPost" /> class.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodyDeleteRunsAbacApiV1RunsDeleteTracesPost(
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::System.Guid> traceIds)
        {
            this.SessionId = sessionId;
            this.TraceIds = traceIds ?? throw new global::System.ArgumentNullException(nameof(traceIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyDeleteRunsAbacApiV1RunsDeleteTracesPost" /> class.
        /// </summary>
        public BodyDeleteRunsAbacApiV1RunsDeleteTracesPost()
        {
        }
    }
}