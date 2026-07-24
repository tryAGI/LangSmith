
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TracerSessionIssuesAgentSaveOverviewResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

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
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentSaveOverviewResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="sessionAgentOverviewRepoId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TracerSessionIssuesAgentSaveOverviewResponse(
            string? commitHash,
            string? sessionAgentOverviewRepoId)
        {
            this.CommitHash = commitHash;
            this.SessionAgentOverviewRepoId = sessionAgentOverviewRepoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TracerSessionIssuesAgentSaveOverviewResponse" /> class.
        /// </summary>
        public TracerSessionIssuesAgentSaveOverviewResponse()
        {
        }

    }
}