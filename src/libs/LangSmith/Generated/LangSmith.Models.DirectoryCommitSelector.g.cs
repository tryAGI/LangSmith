
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DirectoryCommitSelector
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.DirectoryCommitSelectorTypeJsonConverter))]
        public global::LangSmith.DirectoryCommitSelectorType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid CommitId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCommitSelector" /> class.
        /// </summary>
        /// <param name="commitId"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DirectoryCommitSelector(
            global::System.Guid commitId,
            global::LangSmith.DirectoryCommitSelectorType type)
        {
            this.Type = type;
            this.CommitId = commitId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryCommitSelector" /> class.
        /// </summary>
        public DirectoryCommitSelector()
        {
        }

    }
}