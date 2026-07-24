
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthOAuthClientView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_scopes")]
        public global::System.Collections.Generic.IList<string>? AllowedScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_type")]
        public string? ClientType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_uri")]
        public string? ClientUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types")]
        public global::System.Collections.Generic.IList<string>? GrantTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("policy_uri")]
        public string? PolicyUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uris")]
        public global::System.Collections.Generic.IList<string>? RedirectUris { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tos_uri")]
        public string? TosUri { get; set; }

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
        /// Initializes a new instance of the <see cref="OauthOAuthClientView" /> class.
        /// </summary>
        /// <param name="allowedScopes"></param>
        /// <param name="clientId"></param>
        /// <param name="clientName"></param>
        /// <param name="clientType"></param>
        /// <param name="clientUri"></param>
        /// <param name="createdAt"></param>
        /// <param name="disabled"></param>
        /// <param name="grantTypes"></param>
        /// <param name="id"></param>
        /// <param name="logoUri"></param>
        /// <param name="policyUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="tosUri"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthOAuthClientView(
            global::System.Collections.Generic.IList<string>? allowedScopes,
            string? clientId,
            string? clientName,
            string? clientType,
            string? clientUri,
            string? createdAt,
            bool? disabled,
            global::System.Collections.Generic.IList<string>? grantTypes,
            string? id,
            string? logoUri,
            string? policyUri,
            global::System.Collections.Generic.IList<string>? redirectUris,
            string? tosUri,
            string? updatedAt)
        {
            this.AllowedScopes = allowedScopes;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.ClientType = clientType;
            this.ClientUri = clientUri;
            this.CreatedAt = createdAt;
            this.Disabled = disabled;
            this.GrantTypes = grantTypes;
            this.Id = id;
            this.LogoUri = logoUri;
            this.PolicyUri = policyUri;
            this.RedirectUris = redirectUris;
            this.TosUri = tosUri;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOAuthClientView" /> class.
        /// </summary>
        public OauthOAuthClientView()
        {
        }

    }
}