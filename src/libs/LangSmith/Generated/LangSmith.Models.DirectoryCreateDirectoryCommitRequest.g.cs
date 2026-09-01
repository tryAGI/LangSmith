
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Example: {"files":{"skills/current":{"type":"skill","repo_handle":"shared-skill","selector":{"type":"LATEST"}},"agents/pinned":{"type":"agent","repo_handle":"review-agent","selector":{"type":"COMMIT","commit_id":"0198f3ab-7c2d-7def-8a91-23456789abcd"}}}}
    /// </summary>
    public sealed partial class DirectoryCreateDirectoryCommitRequest
    {
        /// <summary>
        /// Paths to create, update, link, delete, or unlink. Use null to delete or unlink an existing path.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public object? Files { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_commit")]
        public string? ParentCommit { get; set; }

        /// <summary>
        /// SkipWebhooks suppresses Context Hub commit webhooks for this commit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_webhooks")]
        public bool? SkipWebhooks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateDirectoryCommitRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Paths to create, update, link, delete, or unlink. Use null to delete or unlink an existing path.
        /// </param>
        /// <param name="parentCommit"></param>
        /// <param name="skipWebhooks">
        /// SkipWebhooks suppresses Context Hub commit webhooks for this commit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryCreateDirectoryCommitRequest(
            object? files,
            string? parentCommit,
            bool? skipWebhooks)
        {
            this.Files = files;
            this.ParentCommit = parentCommit;
            this.SkipWebhooks = skipWebhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCreateDirectoryCommitRequest" /> class.
        /// </summary>
        public DirectoryCreateDirectoryCommitRequest()
        {
        }

    }
}