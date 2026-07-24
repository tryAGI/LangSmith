
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthClientRegistrationRequest
    {
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
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types")]
        public global::System.Collections.Generic.IList<string>? GrantTypes { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types")]
        public global::System.Collections.Generic.IList<string>? ResponseTypes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_method")]
        public string? TokenEndpointAuthMethod { get; set; }

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
        /// Initializes a new instance of the <see cref="OauthClientRegistrationRequest" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="grantTypes"></param>
        /// <param name="logoUri"></param>
        /// <param name="policyUri"></param>
        /// <param name="redirectUris"></param>
        /// <param name="responseTypes"></param>
        /// <param name="scope"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
        /// <param name="tosUri"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthClientRegistrationRequest(
            string? clientName,
            string? clientUri,
            global::System.Collections.Generic.IList<string>? grantTypes,
            string? logoUri,
            string? policyUri,
            global::System.Collections.Generic.IList<string>? redirectUris,
            global::System.Collections.Generic.IList<string>? responseTypes,
            string? scope,
            string? tokenEndpointAuthMethod,
            string? tosUri)
        {
            this.ClientName = clientName;
            this.ClientUri = clientUri;
            this.GrantTypes = grantTypes;
            this.LogoUri = logoUri;
            this.PolicyUri = policyUri;
            this.RedirectUris = redirectUris;
            this.ResponseTypes = responseTypes;
            this.Scope = scope;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
            this.TosUri = tosUri;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthClientRegistrationRequest" /> class.
        /// </summary>
        public OauthClientRegistrationRequest()
        {
        }

    }
}