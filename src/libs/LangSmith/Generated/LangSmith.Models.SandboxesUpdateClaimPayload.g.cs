
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesUpdateClaimPayload
    {
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateClaimPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUpdateClaimPayload(
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig)
        {
            this.Name = name;
            this.ProxyConfig = proxyConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateClaimPayload" /> class.
        /// </summary>
        public SandboxesUpdateClaimPayload()
        {
        }
    }
}