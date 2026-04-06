
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesServiceURLResponse
    {
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
        /// 
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
        /// <param name="browserUrl"></param>
        /// <param name="expiresAt"></param>
        /// <param name="serviceUrl"></param>
        /// <param name="token"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLResponse(
            string? browserUrl,
            string? expiresAt,
            string? serviceUrl,
            string? token)
        {
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