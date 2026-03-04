
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitsCommitWithLookups
    {
        /// <summary>
        /// The hash of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// When the commit was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Example run IDs associated with the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("example_run_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ExampleRunIds { get; set; }

        /// <summary>
        /// Author's full name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_name")]
        public string? FullName { get; set; }

        /// <summary>
        /// The commit ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The manifest of the commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest")]
        public object? Manifest { get; set; }

        /// <summary>
        /// The SHA of the manifest
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manifest_sha")]
        public global::System.Collections.Generic.IList<int>? ManifestSha { get; set; }

        /// <summary>
        /// Number of API downloads
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_downloads")]
        public int? NumDownloads { get; set; }

        /// <summary>
        /// Number of web views
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_views")]
        public int? NumViews { get; set; }

        /// <summary>
        /// The hash of the parent commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_commit_hash")]
        public string? ParentCommitHash { get; set; }

        /// <summary>
        /// The ID of the parent commit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public global::System.Guid? ParentId { get; set; }

        /// <summary>
        /// Repository ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_id")]
        public global::System.Guid? RepoId { get; set; }

        /// <summary>
        /// When the commit was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCommitWithLookups" /> class.
        /// </summary>
        /// <param name="commitHash">
        /// The hash of the commit
        /// </param>
        /// <param name="createdAt">
        /// When the commit was created
        /// </param>
        /// <param name="exampleRunIds">
        /// Example run IDs associated with the commit
        /// </param>
        /// <param name="fullName">
        /// Author's full name
        /// </param>
        /// <param name="id">
        /// The commit ID
        /// </param>
        /// <param name="manifest">
        /// The manifest of the commit
        /// </param>
        /// <param name="manifestSha">
        /// The SHA of the manifest
        /// </param>
        /// <param name="numDownloads">
        /// Number of API downloads
        /// </param>
        /// <param name="numViews">
        /// Number of web views
        /// </param>
        /// <param name="parentCommitHash">
        /// The hash of the parent commit
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent commit
        /// </param>
        /// <param name="repoId">
        /// Repository ID
        /// </param>
        /// <param name="updatedAt">
        /// When the commit was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitsCommitWithLookups(
            string? commitHash,
            global::System.DateTime? createdAt,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleRunIds,
            string? fullName,
            global::System.Guid? id,
            object? manifest,
            global::System.Collections.Generic.IList<int>? manifestSha,
            int? numDownloads,
            int? numViews,
            string? parentCommitHash,
            global::System.Guid? parentId,
            global::System.Guid? repoId,
            global::System.DateTime? updatedAt)
        {
            this.CommitHash = commitHash;
            this.CreatedAt = createdAt;
            this.ExampleRunIds = exampleRunIds;
            this.FullName = fullName;
            this.Id = id;
            this.Manifest = manifest;
            this.ManifestSha = manifestSha;
            this.NumDownloads = numDownloads;
            this.NumViews = numViews;
            this.ParentCommitHash = parentCommitHash;
            this.ParentId = parentId;
            this.RepoId = repoId;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCommitWithLookups" /> class.
        /// </summary>
        public CommitsCommitWithLookups()
        {
        }
    }
}