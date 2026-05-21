
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsStreamRunRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public global::System.Guid? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        public global::System.Collections.Generic.IList<global::LangSmith.ThreadsMessage>? Messages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_mode")]
        public global::System.Collections.Generic.IList<string>? StreamMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_subgraphs")]
        public bool? StreamSubgraphs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_timezone")]
        public string? UserTimezone { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsStreamRunRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="messages"></param>
        /// <param name="streamMode"></param>
        /// <param name="streamSubgraphs"></param>
        /// <param name="userTimezone"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsStreamRunRequest(
            global::System.Guid? agentId,
            global::System.Collections.Generic.IList<global::LangSmith.ThreadsMessage>? messages,
            global::System.Collections.Generic.IList<string>? streamMode,
            bool? streamSubgraphs,
            string? userTimezone)
        {
            this.AgentId = agentId;
            this.Messages = messages;
            this.StreamMode = streamMode;
            this.StreamSubgraphs = streamSubgraphs;
            this.UserTimezone = userTimezone;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsStreamRunRequest" /> class.
        /// </summary>
        public ThreadsStreamRunRequest()
        {
        }

    }
}