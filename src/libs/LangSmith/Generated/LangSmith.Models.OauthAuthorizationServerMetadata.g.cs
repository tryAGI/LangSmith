
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthAuthorizationServerMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorization_endpoint")]
        public string? AuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_methods_supported")]
        public global::System.Collections.Generic.IList<string>? CodeChallengeMethodsSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_authorization_endpoint")]
        public string? DeviceAuthorizationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types_supported")]
        public global::System.Collections.Generic.IList<string>? GrantTypesSupported { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("protected_resources_supported")]
        public global::System.Collections.Generic.IList<string>? ProtectedResourcesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registration_endpoint")]
        public string? RegistrationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_parameter_supported")]
        public bool? ResourceParameterSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_types_supported")]
        public global::System.Collections.Generic.IList<string>? ResponseTypesSupported { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revocation_endpoint")]
        public string? RevocationEndpoint { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes_supported")]
        public global::System.Collections.Generic.IList<string>? ScopesSupported { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthAuthorizationServerMetadata" /> class.
        /// </summary>
        /// <param name="authorizationEndpoint"></param>
        /// <param name="codeChallengeMethodsSupported"></param>
        /// <param name="deviceAuthorizationEndpoint"></param>
        /// <param name="grantTypesSupported"></param>
        /// <param name="issuer"></param>
        /// <param name="jwksUri"></param>
        /// <param name="protectedResourcesSupported"></param>
        /// <param name="registrationEndpoint"></param>
        /// <param name="resourceParameterSupported"></param>
        /// <param name="responseTypesSupported"></param>
        /// <param name="revocationEndpoint"></param>
        /// <param name="scopesSupported"></param>
        /// <param name="tokenEndpoint"></param>
        /// <param name="tokenEndpointAuthMethodsSupported"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthAuthorizationServerMetadata(
            string? authorizationEndpoint,
            global::System.Collections.Generic.IList<string>? codeChallengeMethodsSupported,
            string? deviceAuthorizationEndpoint,
            global::System.Collections.Generic.IList<string>? grantTypesSupported,
            string? issuer,
            string? jwksUri,
            global::System.Collections.Generic.IList<string>? protectedResourcesSupported,
            string? registrationEndpoint,
            bool? resourceParameterSupported,
            global::System.Collections.Generic.IList<string>? responseTypesSupported,
            string? revocationEndpoint,
            global::System.Collections.Generic.IList<string>? scopesSupported,
            string? tokenEndpoint,
            global::System.Collections.Generic.IList<string>? tokenEndpointAuthMethodsSupported)
        {
            this.AuthorizationEndpoint = authorizationEndpoint;
            this.CodeChallengeMethodsSupported = codeChallengeMethodsSupported;
            this.DeviceAuthorizationEndpoint = deviceAuthorizationEndpoint;
            this.GrantTypesSupported = grantTypesSupported;
            this.Issuer = issuer;
            this.JwksUri = jwksUri;
            this.ProtectedResourcesSupported = protectedResourcesSupported;
            this.RegistrationEndpoint = registrationEndpoint;
            this.ResourceParameterSupported = resourceParameterSupported;
            this.ResponseTypesSupported = responseTypesSupported;
            this.RevocationEndpoint = revocationEndpoint;
            this.ScopesSupported = scopesSupported;
            this.TokenEndpoint = tokenEndpoint;
            this.TokenEndpointAuthMethodsSupported = tokenEndpointAuthMethodsSupported;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthAuthorizationServerMetadata" /> class.
        /// </summary>
        public OauthAuthorizationServerMetadata()
        {
        }

    }
}