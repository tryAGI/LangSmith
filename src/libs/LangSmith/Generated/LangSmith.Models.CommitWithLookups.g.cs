
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// All database fields for commits, plus helpful computed fields.
    /// </summary>
    public sealed partial class CommitWithLookups
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Manifest { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid RepoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public global::System.Guid? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_run_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> ExampleRunIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_downloads")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumDownloads { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_views")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NumViews { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_commit_hash")]
        public string? ParentCommitHash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitWithLookups" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="manifest"></param>
        /// <param name="repoId"></param>
        /// <param name="parentId"></param>
        /// <param name="commitHash"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="exampleRunIds"></param>
        /// <param name="numDownloads"></param>
        /// <param name="numViews"></param>
        /// <param name="parentCommitHash"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitWithLookups(
            global::System.Guid id,
            object manifest,
            global::System.Guid repoId,
            string commitHash,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            global::System.Collections.Generic.IList<global::System.Guid> exampleRunIds,
            int numDownloads,
            int numViews,
            global::System.Guid? parentId,
            string? parentCommitHash)
        {
            this.Id = id;
            this.Manifest = manifest ?? throw new global::System.ArgumentNullException(nameof(manifest));
            this.RepoId = repoId;
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ExampleRunIds = exampleRunIds ?? throw new global::System.ArgumentNullException(nameof(exampleRunIds));
            this.NumDownloads = numDownloads;
            this.NumViews = numViews;
            this.ParentId = parentId;
            this.ParentCommitHash = parentCommitHash;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitWithLookups" /> class.
        /// </summary>
        public CommitWithLookups()
        {
        }
    }
}