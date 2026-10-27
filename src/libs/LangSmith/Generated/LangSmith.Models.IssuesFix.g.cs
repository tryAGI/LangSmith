
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IssuesFix
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("branch")]
        public string? Branch { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pr_number")]
        public int? PrNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.RepohostProviderJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.RepohostProvider Provider { get; set; }

        /// <summary>
        /// ProviderWebBaseURL is the instance the fix was opened on; null on GitHub fixes from before it was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_web_base_url")]
        public string? ProviderWebBaseUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RepoUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesFix" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <param name="repoUrl"></param>
        /// <param name="updatedAt"></param>
        /// <param name="branch"></param>
        /// <param name="prNumber"></param>
        /// <param name="providerWebBaseUrl">
        /// ProviderWebBaseURL is the instance the fix was opened on; null on GitHub fixes from before it was recorded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IssuesFix(
            global::System.DateTime createdAt,
            string id,
            global::LangSmith.RepohostProvider provider,
            string repoUrl,
            global::System.DateTime updatedAt,
            string? branch,
            int? prNumber,
            string? providerWebBaseUrl)
        {
            this.Branch = branch;
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.PrNumber = prNumber;
            this.Provider = provider;
            this.ProviderWebBaseUrl = providerWebBaseUrl;
            this.RepoUrl = repoUrl ?? throw new global::System.ArgumentNullException(nameof(repoUrl));
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IssuesFix" /> class.
        /// </summary>
        public IssuesFix()
        {
        }

    }
}