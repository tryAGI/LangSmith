
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsHealthResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checked_at")]
        public global::System.DateTime? CheckedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_check")]
        public global::LangSmith.AgentsMCPCheck? McpCheck { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsHealthResponse" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="checkedAt"></param>
        /// <param name="mcpCheck"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsHealthResponse(
            string? agentId,
            global::System.DateTime? checkedAt,
            global::LangSmith.AgentsMCPCheck? mcpCheck)
        {
            this.AgentId = agentId;
            this.CheckedAt = checkedAt;
            this.McpCheck = mcpCheck;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsHealthResponse" /> class.
        /// </summary>
        public AgentsHealthResponse()
        {
        }

    }
}