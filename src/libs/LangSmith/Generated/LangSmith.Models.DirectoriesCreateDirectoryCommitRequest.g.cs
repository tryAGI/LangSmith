
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectoriesCreateDirectoryCommitRequest
    {
        /// <summary>
        /// Files maps path to an Entry (object = create/update/link, null = delete/unlink).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        public object? Files { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_commit")]
        public string? ParentCommit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesCreateDirectoryCommitRequest" /> class.
        /// </summary>
        /// <param name="files">
        /// Files maps path to an Entry (object = create/update/link, null = delete/unlink).
        /// </param>
        /// <param name="parentCommit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoriesCreateDirectoryCommitRequest(
            object? files,
            string? parentCommit)
        {
            this.Files = files;
            this.ParentCommit = parentCommit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesCreateDirectoryCommitRequest" /> class.
        /// </summary>
        public DirectoriesCreateDirectoryCommitRequest()
        {
        }

    }
}