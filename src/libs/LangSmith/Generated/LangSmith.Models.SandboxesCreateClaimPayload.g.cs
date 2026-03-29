
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreateClaimPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_ttl_seconds")]
        public int? IdleTtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TemplateName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("wait_for_ready")]
        public bool? WaitForReady { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateClaimPayload" /> class.
        /// </summary>
        /// <param name="templateName"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="timeout"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="waitForReady"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateClaimPayload(
            string templateName,
            int? idleTtlSeconds,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            int? timeout,
            int? ttlSeconds,
            bool? waitForReady)
        {
            this.IdleTtlSeconds = idleTtlSeconds;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.TemplateName = templateName ?? throw new global::System.ArgumentNullException(nameof(templateName));
            this.Timeout = timeout;
            this.TtlSeconds = ttlSeconds;
            this.WaitForReady = waitForReady;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateClaimPayload" /> class.
        /// </summary>
        public SandboxesCreateClaimPayload()
        {
        }
    }
}