
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsCreateThreadAndRunRequest
    {
        /// <summary>
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thread")]
        public global::LangSmith.ThreadsCreateThreadAndRunThread? Thread { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadAndRunRequest" /> class.
        /// </summary>
        /// <param name="agentId">
        /// Example: 11111111-1111-1111-1111-111111111111
        /// </param>
        /// <param name="thread"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsCreateThreadAndRunRequest(
            string? agentId,
            global::LangSmith.ThreadsCreateThreadAndRunThread? thread)
        {
            this.AgentId = agentId;
            this.Thread = thread;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsCreateThreadAndRunRequest" /> class.
        /// </summary>
        public ThreadsCreateThreadAndRunRequest()
        {
        }

    }
}