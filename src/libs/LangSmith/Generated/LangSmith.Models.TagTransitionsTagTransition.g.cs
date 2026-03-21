
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TagTransitionsTagTransition
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_commit_hash")]
        public string? FromCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_commit_id")]
        public string? FromCommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_by")]
        public string? PerformedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("performed_by_name")]
        public string? PerformedByName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        public string? RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_name")]
        public string? TagName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_commit_hash")]
        public string? ToCommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to_commit_id")]
        public string? ToCommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TagTransitionsTagTransition" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="fromCommitHash"></param>
        /// <param name="fromCommitId"></param>
        /// <param name="id"></param>
        /// <param name="performedBy"></param>
        /// <param name="performedByName"></param>
        /// <param name="repoId"></param>
        /// <param name="tagName"></param>
        /// <param name="toCommitHash"></param>
        /// <param name="toCommitId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TagTransitionsTagTransition(
            string? createdAt,
            string? fromCommitHash,
            string? fromCommitId,
            string? id,
            string? performedBy,
            string? performedByName,
            string? repoId,
            string? tagName,
            string? toCommitHash,
            string? toCommitId)
        {
            this.CreatedAt = createdAt;
            this.FromCommitHash = fromCommitHash;
            this.FromCommitId = fromCommitId;
            this.Id = id;
            this.PerformedBy = performedBy;
            this.PerformedByName = performedByName;
            this.RepoId = repoId;
            this.TagName = tagName;
            this.ToCommitHash = toCommitHash;
            this.ToCommitId = toCommitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TagTransitionsTagTransition" /> class.
        /// </summary>
        public TagTransitionsTagTransition()
        {
        }
    }
}