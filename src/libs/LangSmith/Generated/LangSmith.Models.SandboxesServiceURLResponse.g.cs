
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesServiceURLResponse
    {
        /// <summary>
        /// Access echoes the enabled LangSmith login level ("restricted"/"workspace"); omitted in token mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesServiceURLResponseAccessJsonConverter))]
        public global::LangSmith.SandboxesServiceURLResponseAccess? Access { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("browser_url")]
        public string? BrowserUrl { get; set; }

        /// <summary>
        /// EmbedOrigins echoes the origins that may embed the URL, normalized; omitted when there are none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_origins")]
        public global::System.Collections.Generic.IList<string>? EmbedOrigins { get; set; }

        /// <summary>
        /// EmbedURL opens the service in an iframe: the token rides the URL<br/>
        /// fragment, which no server, log or Referer header sees, and the page it<br/>
        /// loads trades it for the cookie. Append &amp;redirect=/path to land<br/>
        /// elsewhere than /. Omitted in LangSmith login mode.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_url")]
        public string? EmbedUrl { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public string? ExpiresAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_url")]
        public string? ServiceUrl { get; set; }

        /// <summary>
        /// Token and ExpiresAt are empty in LangSmith login mode (no token is minted).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token")]
        public string? Token { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLResponse" /> class.
        /// </summary>
        /// <param name="access">
        /// Access echoes the enabled LangSmith login level ("restricted"/"workspace"); omitted in token mode.
        /// </param>
        /// <param name="browserUrl"></param>
        /// <param name="embedOrigins">
        /// EmbedOrigins echoes the origins that may embed the URL, normalized; omitted when there are none.
        /// </param>
        /// <param name="embedUrl">
        /// EmbedURL opens the service in an iframe: the token rides the URL<br/>
        /// fragment, which no server, log or Referer header sees, and the page it<br/>
        /// loads trades it for the cookie. Append &amp;redirect=/path to land<br/>
        /// elsewhere than /. Omitted in LangSmith login mode.
        /// </param>
        /// <param name="expiresAt"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="token">
        /// Token and ExpiresAt are empty in LangSmith login mode (no token is minted).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLResponse(
            global::LangSmith.SandboxesServiceURLResponseAccess? access,
            string? browserUrl,
            global::System.Collections.Generic.IList<string>? embedOrigins,
            string? embedUrl,
            string? expiresAt,
            string? serviceUrl,
            string? token)
        {
            this.Access = access;
            this.BrowserUrl = browserUrl;
            this.EmbedOrigins = embedOrigins;
            this.EmbedUrl = embedUrl;
            this.ExpiresAt = expiresAt;
            this.ServiceUrl = serviceUrl;
            this.Token = token;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLResponse" /> class.
        /// </summary>
        public SandboxesServiceURLResponse()
        {
        }

    }
}