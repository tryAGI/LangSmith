
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CommitsCreateCommitResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("commit")]
        public global::LangSmith.CommitsCommitWithLookups? Commit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCreateCommitResponse" /> class.
        /// </summary>
        /// <param name="commit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CommitsCreateCommitResponse(
            global::LangSmith.CommitsCommitWithLookups? commit)
        {
            this.Commit = commit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommitsCreateCommitResponse" /> class.
        /// </summary>
        public CommitsCreateCommitResponse()
        {
        }
    }
}