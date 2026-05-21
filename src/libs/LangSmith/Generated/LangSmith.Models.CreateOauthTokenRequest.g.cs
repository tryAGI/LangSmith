
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOauthTokenRequest
    {
        /// <summary>
        /// Grant type: authorization_code, urn:ietf:params:oauth:grant-type:device_code, or refresh_token
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrantType { get; set; }

        /// <summary>
        /// OAuth2 client ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Authorization code (authorization_code grant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// PKCE code verifier (authorization_code grant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_verifier")]
        public string? CodeVerifier { get; set; }

        /// <summary>
        /// Redirect URI (authorization_code grant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        public string? RedirectUri { get; set; }

        /// <summary>
        /// Device code (device_code grant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("device_code")]
        public string? DeviceCode { get; set; }

        /// <summary>
        /// Refresh token (refresh_token grant)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("refresh_token")]
        public string? RefreshToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthTokenRequest" /> class.
        /// </summary>
        /// <param name="grantType">
        /// Grant type: authorization_code, urn:ietf:params:oauth:grant-type:device_code, or refresh_token
        /// </param>
        /// <param name="clientId">
        /// OAuth2 client ID
        /// </param>
        /// <param name="code">
        /// Authorization code (authorization_code grant)
        /// </param>
        /// <param name="codeVerifier">
        /// PKCE code verifier (authorization_code grant)
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI (authorization_code grant)
        /// </param>
        /// <param name="deviceCode">
        /// Device code (device_code grant)
        /// </param>
        /// <param name="refreshToken">
        /// Refresh token (refresh_token grant)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOauthTokenRequest(
            string grantType,
            string clientId,
            string? code,
            string? codeVerifier,
            string? redirectUri,
            string? deviceCode,
            string? refreshToken)
        {
            this.GrantType = grantType ?? throw new global::System.ArgumentNullException(nameof(grantType));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.Code = code;
            this.CodeVerifier = codeVerifier;
            this.RedirectUri = redirectUri;
            this.DeviceCode = deviceCode;
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthTokenRequest" /> class.
        /// </summary>
        public CreateOauthTokenRequest()
        {
        }

    }
}