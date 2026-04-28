
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateOauthAuthorizeApproveRequest
    {
        /// <summary>
        /// Organization ID; must match the authenticated org
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// OAuth2 client ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Redirect URI registered with the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("redirect_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RedirectUri { get; set; }

        /// <summary>
        /// PKCE code challenge
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CodeChallenge { get; set; }

        /// <summary>
        /// PKCE method, must be 'S256'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_challenge_method")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CodeChallengeMethod { get; set; }

        /// <summary>
        /// Opaque state value to prevent CSRF
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthAuthorizeApproveRequest" /> class.
        /// </summary>
        /// <param name="organizationId">
        /// Organization ID; must match the authenticated org
        /// </param>
        /// <param name="clientId">
        /// OAuth2 client ID
        /// </param>
        /// <param name="redirectUri">
        /// Redirect URI registered with the client
        /// </param>
        /// <param name="codeChallenge">
        /// PKCE code challenge
        /// </param>
        /// <param name="codeChallengeMethod">
        /// PKCE method, must be 'S256'
        /// </param>
        /// <param name="state">
        /// Opaque state value to prevent CSRF
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateOauthAuthorizeApproveRequest(
            string organizationId,
            string clientId,
            string redirectUri,
            string codeChallenge,
            string codeChallengeMethod,
            string? state)
        {
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.RedirectUri = redirectUri ?? throw new global::System.ArgumentNullException(nameof(redirectUri));
            this.CodeChallenge = codeChallenge ?? throw new global::System.ArgumentNullException(nameof(codeChallenge));
            this.CodeChallengeMethod = codeChallengeMethod ?? throw new global::System.ArgumentNullException(nameof(codeChallengeMethod));
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOauthAuthorizeApproveRequest" /> class.
        /// </summary>
        public CreateOauthAuthorizeApproveRequest()
        {
        }
    }
}