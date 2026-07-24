
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ShareCreateShareTokenRequestBody
    {
        /// <summary>
        /// session_id is the tracing project UUID containing the trace.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public global::System.Guid? SessionId { get; set; }

        /// <summary>
        /// trace_id is the root trace UUID to share.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </summary>
        /// <example>018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("trace_id")]
        public global::System.Guid? TraceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCreateShareTokenRequestBody" /> class.
        /// </summary>
        /// <param name="sessionId">
        /// session_id is the tracing project UUID containing the trace.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
        /// <param name="traceId">
        /// trace_id is the root trace UUID to share.<br/>
        /// Example: 018e4c7e-a9fb-7ef0-a5b6-6ea3a82e9327
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShareCreateShareTokenRequestBody(
            global::System.Guid? sessionId,
            global::System.Guid? traceId)
        {
            this.SessionId = sessionId;
            this.TraceId = traceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShareCreateShareTokenRequestBody" /> class.
        /// </summary>
        public ShareCreateShareTokenRequestBody()
        {
        }

    }
}