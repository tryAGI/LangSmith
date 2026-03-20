
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Fields to create a repo
    /// </summary>
    public sealed partial class CreateRepoRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_handle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("readme")]
        public string? Readme { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Default Value: prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.CreateRepoRequestRepoTypeJsonConverter))]
        public global::LangSmith.CreateRepoRequestRepoType? RepoType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restricted_mode")]
        public bool? RestrictedMode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoRequest" /> class.
        /// </summary>
        /// <param name="repoHandle"></param>
        /// <param name="description"></param>
        /// <param name="readme"></param>
        /// <param name="isPublic"></param>
        /// <param name="tags"></param>
        /// <param name="repoType">
        /// Default Value: prompt
        /// </param>
        /// <param name="restrictedMode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateRepoRequest(
            string repoHandle,
            bool isPublic,
            string? description,
            string? readme,
            global::System.Collections.Generic.IList<string>? tags,
            global::LangSmith.CreateRepoRequestRepoType? repoType,
            bool? restrictedMode)
        {
            this.RepoHandle = repoHandle ?? throw new global::System.ArgumentNullException(nameof(repoHandle));
            this.IsPublic = isPublic;
            this.Description = description;
            this.Readme = readme;
            this.Tags = tags;
            this.RepoType = repoType;
            this.RestrictedMode = restrictedMode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateRepoRequest" /> class.
        /// </summary>
        public CreateRepoRequest()
        {
        }
    }
}