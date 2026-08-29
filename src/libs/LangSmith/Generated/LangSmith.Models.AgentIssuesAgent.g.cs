
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentIssuesAgent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_overview_accepted")]
        public bool? AgentOverviewAccepted { get; set; }

        /// <summary>
        /// AnalysisLevel controls coverage vs cost: "standard" (default), "reduced"<br/>
        /// (one scan a day, fewer traces per scan), or "expanded" (2x traces per<br/>
        /// run). Stored NULL in the DB means standard; reads always return a<br/>
        /// concrete value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentIssuesAgentAnalysisLevelJsonConverter))]
        public global::LangSmith.AgentIssuesAgentAnalysisLevel? AnalysisLevel { get; set; }

        /// <summary>
        /// When true, every fix run on this board opens a pull request instead of<br/>
        /// parking the fix for someone to publish. Defaults to false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auto_open_fix_pr")]
        public bool? AutoOpenFixPr { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("engine_version")]
        public string? EngineVersion { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("issue_count")]
        public int? IssueCount { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_available")]
        public bool? LinearAvailable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_integration")]
        public global::LangSmith.AgentLinearIntegration? LinearIntegration { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linear_sync_health")]
        public global::LangSmith.AgentLinearSyncHealth? LinearSyncHealth { get; set; }

        /// <summary>
        /// PreviewVerifyEnabled lets this board's fix runs use preview deployments<br/>
        /// when issue validation is enabled for its tracing project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_verify_enabled")]
        public bool? PreviewVerifyEnabled { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priorities")]
        public global::System.Collections.Generic.IList<string>? Priorities { get; set; }

        /// <summary>
        /// RunFilter is a runs-filter-DSL string scoping which traces Engine analyzes<br/>
        /// (prompt guidance, not an enforced query). NULL = no scope. Clamped by<br/>
        /// validateRunFilter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_filter")]
        public string? RunFilter { get; set; }

        /// <summary>
        /// SelectedTraceCount is the number of traces Engine inspected in the last 14 days.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selected_trace_count")]
        public int? SelectedTraceCount { get; set; }

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
        /// SessionLCUSpendLimitMonthly is the per-project monthly Engine LCU spend<br/>
        /// limit: NULL/negative = no limit; 0 or positive = monthly cap (spend is<br/>
        /// never negative, so a cap of 0 always reads as reached). Enforced in<br/>
        /// addition to (and independently of) the org-level limit. Serialized as a<br/>
        /// string to preserve NUMERIC(28,6) precision.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_lcu_spend_limit_monthly")]
        public string? SessionLcuSpendLimitMonthly { get; set; }

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
        /// JOINed from tenants (workspace label); resolved server-side so the org-admin list can label rows across workspaces the caller isn't a member of
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_name")]
        public string? TenantName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// User-owned freeform preferences. Engine reads this as authoritative<br/>
        /// context and reconciles it into the Agent Overview on the next scan, but<br/>
        /// never edits it. NULL when the user hasn't set any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_instructions")]
        public string? UserInstructions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIssuesAgent" /> class.
        /// </summary>
        /// <param name="agentOverviewAccepted"></param>
        /// <param name="analysisLevel">
        /// AnalysisLevel controls coverage vs cost: "standard" (default), "reduced"<br/>
        /// (one scan a day, fewer traces per scan), or "expanded" (2x traces per<br/>
        /// run). Stored NULL in the DB means standard; reads always return a<br/>
        /// concrete value.
        /// </param>
        /// <param name="autoOpenFixPr">
        /// When true, every fix run on this board opens a pull request instead of<br/>
        /// parking the fix for someone to publish. Defaults to false.
        /// </param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="createdAt"></param>
        /// <param name="cronEnabled"></param>
        /// <param name="cronSchedule"></param>
        /// <param name="engineVersion"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="id"></param>
        /// <param name="issueCount"></param>
        /// <param name="latestRunId"></param>
        /// <param name="latestThreadId">
        /// IDs of the latest run on LangSmith Deployments; NULL until first trigger.
        /// </param>
        /// <param name="linearAvailable"></param>
        /// <param name="linearIntegration"></param>
        /// <param name="linearSyncHealth"></param>
        /// <param name="previewVerifyEnabled">
        /// PreviewVerifyEnabled lets this board's fix runs use preview deployments<br/>
        /// when issue validation is enabled for its tracing project.
        /// </param>
        /// <param name="priorities"></param>
        /// <param name="runFilter">
        /// RunFilter is a runs-filter-DSL string scoping which traces Engine analyzes<br/>
        /// (prompt guidance, not an enforced query). NULL = no scope. Clamped by<br/>
        /// validateRunFilter.
        /// </param>
        /// <param name="selectedTraceCount">
        /// SelectedTraceCount is the number of traces Engine inspected in the last 14 days.
        /// </param>
        /// <param name="sessionAgentOverviewRepoId"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionLcuSpendLimitMonthly">
        /// SessionLCUSpendLimitMonthly is the per-project monthly Engine LCU spend<br/>
        /// limit: NULL/negative = no limit; 0 or positive = monthly cap (spend is<br/>
        /// never negative, so a cap of 0 always reads as reached). Enforced in<br/>
        /// addition to (and independently of) the org-level limit. Serialized as a<br/>
        /// string to preserve NUMERIC(28,6) precision.
        /// </param>
        /// <param name="sessionName">
        /// JOINed from tracer_session
        /// </param>
        /// <param name="tenantId"></param>
        /// <param name="tenantName">
        /// JOINed from tenants (workspace label); resolved server-side so the org-admin list can label rows across workspaces the caller isn't a member of
        /// </param>
        /// <param name="updatedAt"></param>
        /// <param name="userInstructions">
        /// User-owned freeform preferences. Engine reads this as authoritative<br/>
        /// context and reconciles it into the Agent Overview on the next scan, but<br/>
        /// never edits it. NULL when the user hasn't set any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentIssuesAgent(
            bool? agentOverviewAccepted,
            global::LangSmith.AgentIssuesAgentAnalysisLevel? analysisLevel,
            bool? autoOpenFixPr,
            string? contextHubRepoHandle,
            string? createdAt,
            bool? cronEnabled,
            string? cronSchedule,
            string? engineVersion,
            string? githubBaseBranch,
            string? githubRepoSubdir,
            string? githubRepoUrl,
            string? id,
            int? issueCount,
            string? latestRunId,
            string? latestThreadId,
            bool? linearAvailable,
            global::LangSmith.AgentLinearIntegration? linearIntegration,
            global::LangSmith.AgentLinearSyncHealth? linearSyncHealth,
            bool? previewVerifyEnabled,
            global::System.Collections.Generic.IList<string>? priorities,
            string? runFilter,
            int? selectedTraceCount,
            string? sessionAgentOverviewRepoId,
            string? sessionId,
            string? sessionLcuSpendLimitMonthly,
            string? sessionName,
            string? tenantId,
            string? tenantName,
            string? updatedAt,
            string? userInstructions)
        {
            this.AgentOverviewAccepted = agentOverviewAccepted;
            this.AnalysisLevel = analysisLevel;
            this.AutoOpenFixPr = autoOpenFixPr;
            this.ContextHubRepoHandle = contextHubRepoHandle;
            this.CreatedAt = createdAt;
            this.CronEnabled = cronEnabled;
            this.CronSchedule = cronSchedule;
            this.EngineVersion = engineVersion;
            this.GithubBaseBranch = githubBaseBranch;
            this.GithubRepoSubdir = githubRepoSubdir;
            this.GithubRepoUrl = githubRepoUrl;
            this.Id = id;
            this.IssueCount = issueCount;
            this.LatestRunId = latestRunId;
            this.LatestThreadId = latestThreadId;
            this.LinearAvailable = linearAvailable;
            this.LinearIntegration = linearIntegration;
            this.LinearSyncHealth = linearSyncHealth;
            this.PreviewVerifyEnabled = previewVerifyEnabled;
            this.Priorities = priorities;
            this.RunFilter = runFilter;
            this.SelectedTraceCount = selectedTraceCount;
            this.SessionAgentOverviewRepoId = sessionAgentOverviewRepoId;
            this.SessionId = sessionId;
            this.SessionLcuSpendLimitMonthly = sessionLcuSpendLimitMonthly;
            this.SessionName = sessionName;
            this.TenantId = tenantId;
            this.TenantName = tenantName;
            this.UpdatedAt = updatedAt;
            this.UserInstructions = userInstructions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentIssuesAgent" /> class.
        /// </summary>
        public AgentIssuesAgent()
        {
        }

    }
}