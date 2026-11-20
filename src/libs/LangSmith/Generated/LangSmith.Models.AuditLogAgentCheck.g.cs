
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Agent a request was refused or flagged for, and how the request named it.
    /// </summary>
    public sealed partial class AuditLogAgentCheck
    {
        /// <summary>
        /// agent_disabled: a workspace admin disabled the agent. agent_mismatch: the request's agent access token names another agent than its API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Outcome { get; set; }

        /// <summary>
        /// How the request named the agent: key (an API key bound to the agent), access_token, or fleet_agent. For a refused token request, how the agent proved itself, as in ls_proof.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("found_by")]
        public string? FoundBy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_agent_id")]
        public string? LsAgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_agent_uuid")]
        public string? LsAgentUuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_environment_id")]
        public string? LsEnvironmentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_env")]
        public string? LsEnv { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogAgentCheck" /> class.
        /// </summary>
        /// <param name="outcome">
        /// agent_disabled: a workspace admin disabled the agent. agent_mismatch: the request's agent access token names another agent than its API key.
        /// </param>
        /// <param name="foundBy">
        /// How the request named the agent: key (an API key bound to the agent), access_token, or fleet_agent. For a refused token request, how the agent proved itself, as in ls_proof.
        /// </param>
        /// <param name="lsAgentId"></param>
        /// <param name="lsAgentUuid"></param>
        /// <param name="lsEnvironmentId"></param>
        /// <param name="lsEnv"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogAgentCheck(
            string outcome,
            string? foundBy,
            string? lsAgentId,
            string? lsAgentUuid,
            string? lsEnvironmentId,
            string? lsEnv)
        {
            this.Outcome = outcome ?? throw new global::System.ArgumentNullException(nameof(outcome));
            this.FoundBy = foundBy;
            this.LsAgentId = lsAgentId;
            this.LsAgentUuid = lsAgentUuid;
            this.LsEnvironmentId = lsEnvironmentId;
            this.LsEnv = lsEnv;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogAgentCheck" /> class.
        /// </summary>
        public AuditLogAgentCheck()
        {
        }

    }
}