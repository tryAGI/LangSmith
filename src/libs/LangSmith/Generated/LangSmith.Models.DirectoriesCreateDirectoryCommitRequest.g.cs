
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
        /// SkipWebhooks, when true, suppresses Context Hub commit webhooks for this<br/>
        /// commit. Deliberately a plain bool, not the any (bool | []string) shape of<br/>
        /// the prompt-hub CreateCommitReq.SkipWebhooks: Context Hub v1 has no<br/>
        /// per-webhook filtering, so a bool is the correct shape.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skip_webhooks")]
        public bool? SkipWebhooks { get; set; }

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
        /// <param name="skipWebhooks">
        /// SkipWebhooks, when true, suppresses Context Hub commit webhooks for this<br/>
        /// commit. Deliberately a plain bool, not the any (bool | []string) shape of<br/>
        /// the prompt-hub CreateCommitReq.SkipWebhooks: Context Hub v1 has no<br/>
        /// per-webhook filtering, so a bool is the correct shape.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoriesCreateDirectoryCommitRequest(
            object? files,
            string? parentCommit,
            bool? skipWebhooks)
        {
            this.Files = files;
            this.ParentCommit = parentCommit;
            this.SkipWebhooks = skipWebhooks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoriesCreateDirectoryCommitRequest" /> class.
        /// </summary>
        public DirectoriesCreateDirectoryCommitRequest()
        {
        }

    }
}