
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsOAuthTokenSummary
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_account_label")]
        public string? ProviderAccountLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsOAuthTokenSummary" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="expiresAt"></param>
        /// <param name="id"></param>
        /// <param name="isDefault"></param>
        /// <param name="providerAccountLabel"></param>
        /// <param name="providerId"></param>
        /// <param name="scopes"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsOAuthTokenSummary(
            string? createdAt,
            string? expiresAt,
            string? id,
            bool? isDefault,
            string? providerAccountLabel,
            string? providerId,
            global::System.Collections.Generic.IList<string>? scopes,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.IsDefault = isDefault;
            this.ProviderAccountLabel = providerAccountLabel;
            this.ProviderId = providerId;
            this.Scopes = scopes;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsOAuthTokenSummary" /> class.
        /// </summary>
        public McpVendorsOAuthTokenSummary()
        {
        }
    }
}