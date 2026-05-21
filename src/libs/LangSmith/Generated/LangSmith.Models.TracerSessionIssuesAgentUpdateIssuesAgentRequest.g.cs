
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesAgentUpdateIssuesAgentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_overview_accepted")]
        public bool? AgentOverviewAccepted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("context_hub_repo_handle")]
        public string? ContextHubRepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_enabled")]
        public bool? CronEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_base_branch")]
        public string? GithubBaseBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_repo_subdir")]
        public string? GithubRepoSubdir { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("github_repo_url")]
        public string? GithubRepoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priorities")]
        public global::System.Collections.Generic.IList<string>? Priorities { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_agent_overview_repo_id")]
        public string? SessionAgentOverviewRepoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentUpdateIssuesAgentRequest" /> class.
        /// </summary>
        /// <param name="agentOverviewAccepted"></param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="cronEnabled"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="priorities"></param>
        /// <param name="sessionAgentOverviewRepoId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesAgentUpdateIssuesAgentRequest(
            bool? agentOverviewAccepted,
            string? contextHubRepoHandle,
            bool? cronEnabled,
            string? githubBaseBranch,
            string? githubRepoSubdir,
            string? githubRepoUrl,
            global::System.Collections.Generic.IList<string>? priorities,
            string? sessionAgentOverviewRepoId)
        {
            this.AgentOverviewAccepted = agentOverviewAccepted;
            this.ContextHubRepoHandle = contextHubRepoHandle;
            this.CronEnabled = cronEnabled;
            this.GithubBaseBranch = githubBaseBranch;
            this.GithubRepoSubdir = githubRepoSubdir;
            this.GithubRepoUrl = githubRepoUrl;
            this.Priorities = priorities;
            this.SessionAgentOverviewRepoId = sessionAgentOverviewRepoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentUpdateIssuesAgentRequest" /> class.
        /// </summary>
        public TracerSessionIssuesAgentUpdateIssuesAgentRequest()
        {
        }

    }
}