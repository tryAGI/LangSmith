
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthUpdateOAuthClientRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_scopes")]
        public global::System.Collections.Generic.IList<string>? AllowedScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_uri")]
        public string? ClientUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disabled")]
        public bool? Disabled { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthUpdateOAuthClientRequest" /> class.
        /// </summary>
        /// <param name="allowedScopes"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="disabled"></param>
        /// <param name="logoUri"></param>
        /// <param name="policyUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="tosUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthUpdateOAuthClientRequest(
            global::System.Collections.Generic.IList<string>? allowedScopes,
            string? clientName,
            string? clientUri,
            bool? disabled,
            string? logoUri,
            string? policyUri,
            global::System.Collections.Generic.IList<string>? redirectUris,
            string? tosUri)
        {
            this.AllowedScopes = allowedScopes;
            this.ClientName = clientName;
            this.ClientUri = clientUri;
            this.Disabled = disabled;
            this.LogoUri = logoUri;
            this.PolicyUri = policyUri;
            this.RedirectUris = redirectUris;
            this.TosUri = tosUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthUpdateOAuthClientRequest" /> class.
        /// </summary>
        public OauthUpdateOAuthClientRequest()
        {
        }

    }
}