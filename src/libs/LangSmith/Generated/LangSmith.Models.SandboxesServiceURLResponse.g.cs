
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
            string? expiresAt,
            string? serviceUrl,
            string? token)
        {
            this.Access = access;
            this.BrowserUrl = browserUrl;
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