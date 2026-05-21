
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectoriesGetDirectoryResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        public string? CommitHash { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        public string? CommitId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public object? Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesGetDirectoryResponse" /> class.
        /// </summary>
        /// <param name="commitHash"></param>
        /// <param name="commitId"></param>
        /// <param name="files"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoriesGetDirectoryResponse(
            string? commitHash,
            string? commitId,
            object? files)
        {
            this.CommitHash = commitHash;
            this.CommitId = commitId;
            this.Files = files;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesGetDirectoryResponse" /> class.
        /// </summary>
        public DirectoriesGetDirectoryResponse()
        {
        }

    }
}