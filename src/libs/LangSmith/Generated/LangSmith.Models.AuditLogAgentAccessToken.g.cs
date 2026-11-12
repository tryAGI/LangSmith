
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Claims of a minted agent access token. Never the token itself.
    /// </summary>
    public sealed partial class AuditLogAgentAccessToken
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Sub { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_agent_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LsAgentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_agent_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LsAgentUuid { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_env")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LsEnv { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LsDeploymentId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_proof")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LsProof { get; set; }

        /// <summary>
        /// User the agent acts for, not the actor of the mint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_user_id")]
        public string? LsUserId { get; set; }

        /// <summary>
        /// Cron that started the agent's run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ls_trigger")]
        public global::LangSmith.AuditLogAgentAccessTokenTrigger? LsTrigger { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Aud { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jti")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Jti { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("exp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Exp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogAgentAccessToken" /> class.
        /// </summary>
        /// <param name="sub"></param>
        /// <param name="lsAgentId"></param>
        /// <param name="lsAgentUuid"></param>
        /// <param name="lsEnv"></param>
        /// <param name="lsDeploymentId"></param>
        /// <param name="lsProof"></param>
        /// <param name="aud"></param>
        /// <param name="jti"></param>
        /// <param name="exp"></param>
        /// <param name="lsUserId">
        /// User the agent acts for, not the actor of the mint.
        /// </param>
        /// <param name="lsTrigger">
        /// Cron that started the agent's run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogAgentAccessToken(
            string sub,
            string lsAgentId,
            string lsAgentUuid,
            string lsEnv,
            string lsDeploymentId,
            string lsProof,
            string aud,
            string jti,
            global::System.DateTime exp,
            string? lsUserId,
            global::LangSmith.AuditLogAgentAccessTokenTrigger? lsTrigger)
        {
            this.Sub = sub ?? throw new global::System.ArgumentNullException(nameof(sub));
            this.LsAgentId = lsAgentId ?? throw new global::System.ArgumentNullException(nameof(lsAgentId));
            this.LsAgentUuid = lsAgentUuid ?? throw new global::System.ArgumentNullException(nameof(lsAgentUuid));
            this.LsEnv = lsEnv ?? throw new global::System.ArgumentNullException(nameof(lsEnv));
            this.LsDeploymentId = lsDeploymentId ?? throw new global::System.ArgumentNullException(nameof(lsDeploymentId));
            this.LsProof = lsProof ?? throw new global::System.ArgumentNullException(nameof(lsProof));
            this.LsUserId = lsUserId;
            this.LsTrigger = lsTrigger;
            this.Aud = aud ?? throw new global::System.ArgumentNullException(nameof(aud));
            this.Jti = jti ?? throw new global::System.ArgumentNullException(nameof(jti));
            this.Exp = exp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogAgentAccessToken" /> class.
        /// </summary>
        public AuditLogAgentAccessToken()
        {
        }

    }
}