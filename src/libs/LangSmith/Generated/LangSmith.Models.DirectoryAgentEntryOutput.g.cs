
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectoryAgentEntryOutput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DirectoryAgentEntryOutputTypeJsonConverter))]
        public global::LangSmith.DirectoryAgentEntryOutputType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoHandle { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Owner { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CommitHash { get; set; }

        /// <summary>
        /// The authored selection policy for this linked directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("selector")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DirectoryDirectorySelectorJsonConverter))]
        public global::LangSmith.DirectoryDirectorySelector? Selector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryAgentEntryOutput" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="owner"></param>
        /// <param name="commitHash"></param>
        /// <param name="type"></param>
        /// <param name="selector">
        /// The authored selection policy for this linked directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryAgentEntryOutput(
            string repoHandle,
            string owner,
            string commitHash,
            global::LangSmith.DirectoryAgentEntryOutputType type,
            global::LangSmith.DirectoryDirectorySelector? selector)
        {
            this.Type = type;
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.Owner = owner ?? throw new global::System.ArgumentNullException(nameof(owner));
            this.CommitHash = commitHash ?? throw new global::System.ArgumentNullException(nameof(commitHash));
            this.Selector = selector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryAgentEntryOutput" /> class.
        /// </summary>
        public DirectoryAgentEntryOutput()
        {
        }

    }
}