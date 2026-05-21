
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectoriesCommitInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesCommitInfo" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoriesCommitInfo(
            string? commitHash,
            string? createdAt,
            string? id)
        {
            this.CommitHash = commitHash;
            this.CreatedAt = createdAt;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesCommitInfo" /> class.
        /// </summary>
        public DirectoriesCommitInfo()
        {
        }

    }
}