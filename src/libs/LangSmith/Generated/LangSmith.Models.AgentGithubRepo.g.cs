
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentGithubRepo
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_branch")]
        public string? BaseBranch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGithubRepo" /> class.
        /// </summary>
        /// <param name="baseBranch"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="repoUrl"></param>
        /// <param name="subdir"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentGithubRepo(
            string? baseBranch,
            global::System.DateTime? createdAt,
            string? id,
            string? repoUrl,
            string? subdir,
            global::System.DateTime? updatedAt)
        {
            this.BaseBranch = baseBranch;
            this.CreatedAt = createdAt;
            this.Id = id;
            this.RepoUrl = repoUrl;
            this.Subdir = subdir;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentGithubRepo" /> class.
        /// </summary>
        public AgentGithubRepo()
        {
        }

    }
}