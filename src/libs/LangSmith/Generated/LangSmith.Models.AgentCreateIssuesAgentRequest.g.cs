
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentCreateIssuesAgentRequest
    {
        /// <summary>
        /// AnalysisLevel is how thoroughly Engine monitors the project: "standard"<br/>
        /// (the default), "reduced" (fewer traces at lower cost), or "expanded" (more<br/>
        /// traces per run, for projects with enough tracing volume). Omit for<br/>
        /// "standard".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("analysis_level")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AgentCreateIssuesAgentRequestAnalysisLevelJsonConverter))]
        public global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel? AnalysisLevel { get; set; }

        /// <summary>
        /// AutoOpenFixPR opens a draft pull request for every fix the agent<br/>
        /// produces, instead of waiting for one to be opened from the issue. Has no<br/>
        /// effect without github_repo_url, since a fix has nowhere to open. Omit for<br/>
        /// false.
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
        /// Runs-filter-DSL trace scope; omit/null/empty for no scope.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_filter")]
        public string? RunFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateIssuesAgentRequest" /> class.
        /// </summary>
        /// <param name="analysisLevel">
        /// AnalysisLevel is how thoroughly Engine monitors the project: "standard"<br/>
        /// (the default), "reduced" (fewer traces at lower cost), or "expanded" (more<br/>
        /// traces per run, for projects with enough tracing volume). Omit for<br/>
        /// "standard".
        /// </param>
        /// <param name="autoOpenFixPr">
        /// AutoOpenFixPR opens a draft pull request for every fix the agent<br/>
        /// produces, instead of waiting for one to be opened from the issue. Has no<br/>
        /// effect without github_repo_url, since a fix has nowhere to open. Omit for<br/>
        /// false.
        /// </param>
        /// <param name="contextHubRepoHandle"></param>
        /// <param name="githubBaseBranch"></param>
        /// <param name="githubRepoSubdir"></param>
        /// <param name="githubRepoUrl"></param>
        /// <param name="priorities"></param>
        /// <param name="runFilter">
        /// Runs-filter-DSL trace scope; omit/null/empty for no scope.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentCreateIssuesAgentRequest(
            global::LangSmith.AgentCreateIssuesAgentRequestAnalysisLevel? analysisLevel,
            bool? autoOpenFixPr,
            string? contextHubRepoHandle,
            string? githubBaseBranch,
            string? githubRepoSubdir,
            string? githubRepoUrl,
            global::System.Collections.Generic.IList<string>? priorities,
            string? runFilter)
        {
            this.AnalysisLevel = analysisLevel;
            this.AutoOpenFixPr = autoOpenFixPr;
            this.ContextHubRepoHandle = contextHubRepoHandle;
            this.GithubBaseBranch = githubBaseBranch;
            this.GithubRepoSubdir = githubRepoSubdir;
            this.GithubRepoUrl = githubRepoUrl;
            this.Priorities = priorities;
            this.RunFilter = runFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentCreateIssuesAgentRequest" /> class.
        /// </summary>
        public AgentCreateIssuesAgentRequest()
        {
        }

    }
}