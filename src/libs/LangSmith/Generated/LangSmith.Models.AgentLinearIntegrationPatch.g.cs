
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentLinearIntegrationPatch
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_name")]
        public string? ProjectName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_key")]
        public string? TeamKey { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        public string? TeamName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_name")]
        public string? WorkspaceName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLinearIntegrationPatch" /> class.
        /// </summary>
        /// <param name="enabled"></param>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="teamId"></param>
        /// <param name="teamKey"></param>
        /// <param name="teamName"></param>
        /// <param name="workspaceId"></param>
        /// <param name="workspaceName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentLinearIntegrationPatch(
            bool? enabled,
            string? projectId,
            string? projectName,
            string? teamId,
            string? teamKey,
            string? teamName,
            string? workspaceId,
            string? workspaceName)
        {
            this.Enabled = enabled;
            this.ProjectId = projectId;
            this.ProjectName = projectName;
            this.TeamId = teamId;
            this.TeamKey = teamKey;
            this.TeamName = teamName;
            this.WorkspaceId = workspaceId;
            this.WorkspaceName = workspaceName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentLinearIntegrationPatch" /> class.
        /// </summary>
        public AgentLinearIntegrationPatch()
        {
        }

    }
}