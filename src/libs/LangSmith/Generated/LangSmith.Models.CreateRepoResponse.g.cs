
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateRepoResponse
    {
        /// <summary>
        /// All database fields for repos, plus helpful computed fields.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RepoWithLookups Repo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoResponse" /> class.
        /// </summary>
        /// <param name="repo">
        /// All database fields for repos, plus helpful computed fields.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRepoResponse(
            global::LangSmith.RepoWithLookups repo)
        {
            this.Repo = repo ?? throw new global::System.ArgumentNullException(nameof(repo));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoResponse" /> class.
        /// </summary>
        public CreateRepoResponse()
        {
        }
    }
}