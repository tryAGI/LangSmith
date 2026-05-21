
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
        [global::System.Text.Json.Serialization.JsonPropertyName("grant_types")]
        public global::System.Collections.Generic.IList<string>? GrantTypes { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthClientRegistrationRequest" /> class.
        /// </summary>
        /// <param name="clientName"></param>
        /// <param name="grantTypes"></param>
        /// <param name="redirectUris"></param>
        /// <param name="responseTypes"></param>
        /// <param name="scope"></param>
        /// <param name="tokenEndpointAuthMethod"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthClientRegistrationRequest(
            string? clientName,
            global::System.Collections.Generic.IList<string>? grantTypes,
            global::System.Collections.Generic.IList<string>? redirectUris,
            global::System.Collections.Generic.IList<string>? responseTypes,
            string? scope,
            string? tokenEndpointAuthMethod)
        {
            this.ClientName = clientName;
            this.GrantTypes = grantTypes;
            this.RedirectUris = redirectUris;
            this.ResponseTypes = responseTypes;
            this.Scope = scope;
            this.TokenEndpointAuthMethod = tokenEndpointAuthMethod;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthClientRegistrationRequest" /> class.
        /// </summary>
        public OauthClientRegistrationRequest()
        {
        }

    }
}