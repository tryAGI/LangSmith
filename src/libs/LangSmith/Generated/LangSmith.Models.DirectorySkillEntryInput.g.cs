
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectorySkillEntryInput
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DirectorySkillEntryInputTypeJsonConverter))]
        public global::LangSmith.DirectorySkillEntryInputType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoHandle { get; set; }

        /// <summary>
        /// Deprecated write input. It is accepted for compatibility but ignored for selection, so the link resolves as LATEST. Omit it for LATEST or replace it with selector {"type": "COMMIT", "commit_id": "&lt;uuid&gt;"} to pin a commit. commit_id and selector are mutually exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? CommitId { get; set; }

        /// <summary>
        /// How to select the linked commit. Omit this field to use LATEST.
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
        /// Initializes a new instance of the <see cref="DirectorySkillEntryInput" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="type"></param>
        /// <param name="selector">
        /// How to select the linked commit. Omit this field to use LATEST.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectorySkillEntryInput(
            string repoHandle,
            global::LangSmith.DirectorySkillEntryInputType type,
            global::LangSmith.DirectoryDirectorySelector? selector)
        {
            this.Type = type;
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.Selector = selector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectorySkillEntryInput" /> class.
        /// </summary>
        public DirectorySkillEntryInput()
        {
        }

    }
}