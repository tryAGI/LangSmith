
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentGithubRepoInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_branch")]
        public string? BaseBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_url")]
        public string? RepoUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subdir")]
        public string? Subdir { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGithubRepoInput" /> class.
        /// </summary>
        /// <param name="baseBranch"></param>
        /// <param name="repoUrl"></param>
        /// <param name="subdir"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGithubRepoInput(
            string? baseBranch,
            string? repoUrl,
            string? subdir)
        {
            this.BaseBranch = baseBranch;
            this.RepoUrl = repoUrl;
            this.Subdir = subdir;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGithubRepoInput" /> class.
        /// </summary>
        public AgentGithubRepoInput()
        {
        }

    }
}