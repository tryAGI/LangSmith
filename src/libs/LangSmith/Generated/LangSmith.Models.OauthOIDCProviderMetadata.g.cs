
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthOIDCProviderMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("claims_supported")]
        public global::System.Collections.Generic.IList<string>? ClaimsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_methods_supported")]
        public global::System.Collections.Generic.IList<string>? CodeChallengeMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types_supported")]
        public global::System.Collections.Generic.IList<string>? GrantTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id_token_signing_alg_values_supported")]
        public global::System.Collections.Generic.IList<string>? IdTokenSigningAlgValuesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("issuer")]
        public string? Issuer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jwks_uri")]
        public string? JwksUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_supported")]
        public global::System.Collections.Generic.IList<string>? ScopesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subject_types_supported")]
        public global::System.Collections.Generic.IList<string>? SubjectTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint")]
        public string? TokenEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_endpoint_auth_methods_supported")]
        public global::System.Collections.Generic.IList<string>? TokenEndpointAuthMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userinfo_endpoint")]
        public string? UserinfoEndpoint { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOIDCProviderMetadata" /> class.
        /// </summary>
        /// <param name="authorizationEndpoint"></param>
        /// <param name="claimsSupported"></param>
        /// <param name="codeChallengeMethodsSupported"></param>
        /// <param name="grantTypesSupported"></param>
        /// <param name="idTokenSigningAlgValuesSupported"></param>
        /// <param name="issuer"></param>
        /// <param name="jwksUri"></param>
        /// <param name="responseTypesSupported"></param>
        /// <param name="scopesSupported"></param>
        /// <param name="subjectTypesSupported"></param>
        /// <param name="tokenEndpoint"></param>
        /// <param name="tokenEndpointAuthMethodsSupported"></param>
        /// <param name="userinfoEndpoint"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthOIDCProviderMetadata(
            string? authorizationEndpoint,
            global::System.Collections.Generic.IList<string>? claimsSupported,
            global::System.Collections.Generic.IList<string>? codeChallengeMethodsSupported,
            global::System.Collections.Generic.IList<string>? grantTypesSupported,
            global::System.Collections.Generic.IList<string>? idTokenSigningAlgValuesSupported,
            string? issuer,
            string? jwksUri,
            global::System.Collections.Generic.IList<string>? responseTypesSupported,
            global::System.Collections.Generic.IList<string>? scopesSupported,
            global::System.Collections.Generic.IList<string>? subjectTypesSupported,
            string? tokenEndpoint,
            global::System.Collections.Generic.IList<string>? tokenEndpointAuthMethodsSupported,
            string? userinfoEndpoint)
        {
            this.AuthorizationEndpoint = authorizationEndpoint;
            this.ClaimsSupported = claimsSupported;
            this.CodeChallengeMethodsSupported = codeChallengeMethodsSupported;
            this.GrantTypesSupported = grantTypesSupported;
            this.IdTokenSigningAlgValuesSupported = idTokenSigningAlgValuesSupported;
            this.Issuer = issuer;
            this.JwksUri = jwksUri;
            this.ResponseTypesSupported = responseTypesSupported;
            this.ScopesSupported = scopesSupported;
            this.SubjectTypesSupported = subjectTypesSupported;
            this.TokenEndpoint = tokenEndpoint;
            this.TokenEndpointAuthMethodsSupported = tokenEndpointAuthMethodsSupported;
            this.UserinfoEndpoint = userinfoEndpoint;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthOIDCProviderMetadata" /> class.
        /// </summary>
        public OauthOIDCProviderMetadata()
        {
        }

    }
}