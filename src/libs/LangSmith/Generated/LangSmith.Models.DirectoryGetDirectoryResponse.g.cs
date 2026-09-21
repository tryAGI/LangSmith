
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectoryGetDirectoryResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitHash { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CommitId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryGetDirectoryResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="commitId"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryGetDirectoryResponse(
            string commitHash,
            global::System.Guid commitId,
            global::System.Collections.Generic.Dictionary<string, global::LangSmith.DirectoryDirectoryEntryOutput> files)
        {
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.CommitId = commitId;
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryGetDirectoryResponse" /> class.
        /// </summary>
        public DirectoryGetDirectoryResponse()
        {
        }

    }
}