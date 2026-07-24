
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OauthAuthorizedAppView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("authorized_at")]
        public string? AuthorizedAt { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("client_uri")]
        public string? ClientUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logo_uri")]
        public string? LogoUri { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthAuthorizedAppView" /> class.
        /// </summary>
        /// <param name="authorizedAt"></param>
        /// <param name="clientId"></param>
        /// <param name="clientName"></param>
        /// <param name="clientUri"></param>
        /// <param name="logoUri"></param>
        /// <param name="scopes"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OauthAuthorizedAppView(
            string? authorizedAt,
            string? clientId,
            string? clientName,
            string? clientUri,
            string? logoUri,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.AuthorizedAt = authorizedAt;
            this.ClientId = clientId;
            this.ClientName = clientName;
            this.ClientUri = clientUri;
            this.LogoUri = logoUri;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OauthAuthorizedAppView" /> class.
        /// </summary>
        public OauthAuthorizedAppView()
        {
        }

    }
}