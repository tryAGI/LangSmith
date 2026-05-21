
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesAgentIssuesAgent
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
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_enabled")]
        public bool? CronEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cron_schedule")]
        public string? CronSchedule { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_run_id")]
        public string? LatestRunId { get; set; }

        /// <summary>
        /// IDs of the latest run on LangSmith Deployments; NULL until first trigger.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("latest_thread_id")]
        public string? LatestThreadId { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        public string? SessionId { get; set; }

        /// <summary>
        /// JOINed from tracer_session
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_name")]
        public string? SessionName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentIssuesAgent" /> class.
        /// </summary>
        /// <param name="agentOverviewAccepted"></param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="createdAt"></param>
        /// <param name="cronEnabled"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="id"></param>
        /// <param name="latestRunId"></param>
        /// <param name="latestThreadId">
        /// IDs of the latest run on LangSmith Deployments; NULL until first trigger.
        /// </param>
        /// <param name="priorities"></param>
        /// <param name="sessionAgentOverviewRepoId"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName">
        /// JOINed from tracer_session
        /// </param>
        /// <param name="tenantId"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesAgentIssuesAgent(
            bool? agentOverviewAccepted,
            string? contextHubRepoHandle,
            string? createdAt,
            bool? cronEnabled,
            string? cronSchedule,
            string? githubBaseBranch,
            string? githubRepoSubdir,
            string? githubRepoUrl,
            string? id,
            string? latestRunId,
            string? latestThreadId,
            global::System.Collections.Generic.IList<string>? priorities,
            string? sessionAgentOverviewRepoId,
            string? sessionId,
            string? sessionName,
            string? tenantId,
            string? updatedAt)
        {
            this.AgentOverviewAccepted = agentOverviewAccepted;
            this.ContextHubRepoHandle = contextHubRepoHandle;
            this.CreatedAt = createdAt;
            this.CronEnabled = cronEnabled;
            this.CronSchedule = cronSchedule;
            this.GithubBaseBranch = githubBaseBranch;
            this.GithubRepoSubdir = githubRepoSubdir;
            this.GithubRepoUrl = githubRepoUrl;
            this.Id = id;
            this.LatestRunId = latestRunId;
            this.LatestThreadId = latestThreadId;
            this.Priorities = priorities;
            this.SessionAgentOverviewRepoId = sessionAgentOverviewRepoId;
            this.SessionId = sessionId;
            this.SessionName = sessionName;
            this.TenantId = tenantId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentIssuesAgent" /> class.
        /// </summary>
        public TracerSessionIssuesAgentIssuesAgent()
        {
        }

    }
}