
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
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_verify_enabled")]
        public bool? PreviewVerifyEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priorities")]
        public global::System.Collections.Generic.IList<string>? Priorities { get; set; }

        /// <summary>
        /// Trace-scope DSL. nil = don't change; "" clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_filter")]
        public string? RunFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_agent_overview_repo_id")]
        public string? SessionAgentOverviewRepoId { get; set; }

        /// <summary>
        /// SessionLCUSpendLimitMonthly sets the per-project monthly LCU spend limit.<br/>
        /// Tri-state: absent (nil) = don't change; 0 or positive = monthly cap (a cap<br/>
        /// of 0 is always reached, blocking new runs); negative clears it (stored as<br/>
        /// NULL = no limit). The frontend sends a negative number to clear rather<br/>
        /// than null, since null is indistinguishable from "absent". Serialized as a<br/>
        /// string to preserve NUMERIC precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_lcu_spend_limit_monthly")]
        public string? SessionLcuSpendLimitMonthly { get; set; }

        /// <summary>
        /// Freeform user preferences. Send "" to clear (the frontend must not send null).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_instructions")]
        public string? UserInstructions { get; set; }

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
        /// <param name="previewVerifyEnabled"></param>
        /// <param name="priorities"></param>
        /// <param name="runFilter">
        /// Trace-scope DSL. nil = don't change; "" clears it.
        /// </param>
        /// <param name="sessionAgentOverviewRepoId"></param>
        /// <param name="sessionLcuSpendLimitMonthly">
        /// SessionLCUSpendLimitMonthly sets the per-project monthly LCU spend limit.<br/>
        /// Tri-state: absent (nil) = don't change; 0 or positive = monthly cap (a cap<br/>
        /// of 0 is always reached, blocking new runs); negative clears it (stored as<br/>
        /// NULL = no limit). The frontend sends a negative number to clear rather<br/>
        /// than null, since null is indistinguishable from "absent". Serialized as a<br/>
        /// string to preserve NUMERIC precision.
        /// </param>
        /// <param name="userInstructions">
        /// Freeform user preferences. Send "" to clear (the frontend must not send null).
        /// </param>
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
            bool? previewVerifyEnabled,
            global::System.Collections.Generic.IList<string>? priorities,
            string? runFilter,
            string? sessionAgentOverviewRepoId,
            string? sessionLcuSpendLimitMonthly,
            string? userInstructions)
        {
            this.AgentOverviewAccepted = agentOverviewAccepted;
            this.ContextHubRepoHandle = contextHubRepoHandle;
            this.CronEnabled = cronEnabled;
            this.GithubBaseBranch = githubBaseBranch;
            this.GithubRepoSubdir = githubRepoSubdir;
            this.GithubRepoUrl = githubRepoUrl;
            this.PreviewVerifyEnabled = previewVerifyEnabled;
            this.Priorities = priorities;
            this.RunFilter = runFilter;
            this.SessionAgentOverviewRepoId = sessionAgentOverviewRepoId;
            this.SessionLcuSpendLimitMonthly = sessionLcuSpendLimitMonthly;
            this.UserInstructions = userInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentUpdateIssuesAgentRequest" /> class.
        /// </summary>
        public TracerSessionIssuesAgentUpdateIssuesAgentRequest()
        {
        }

    }
}