
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Response for listing repo owners.
    /// </summary>
    public sealed partial class ListRepoOwnersResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owners")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.RepoOwner> Owners { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepoOwnersResponse" /> class.
        /// </summary>
        /// <param name="owners"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListRepoOwnersResponse(
            global::System.Collections.Generic.IList<global::LangSmith.RepoOwner> owners)
        {
            this.Owners = owners ?? throw new global::System.ArgumentNullException(nameof(owners));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepoOwnersResponse" /> class.
        /// </summary>
        public ListRepoOwnersResponse()
        {
        }
    }
}