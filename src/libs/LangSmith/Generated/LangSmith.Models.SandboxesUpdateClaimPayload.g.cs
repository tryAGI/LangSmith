
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
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_capacity_bytes")]
        public long? FsCapacityBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_ttl_seconds")]
        public int? IdleTtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mem_bytes")]
        public long? MemBytes { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        public int? Vcpus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateClaimPayload" /> class.
        /// </summary>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="vcpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUpdateClaimPayload(
            long? fsCapacityBytes,
            int? idleTtlSeconds,
            long? memBytes,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            int? ttlSeconds,
            int? vcpus)
        {
            this.FsCapacityBytes = fsCapacityBytes;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.MemBytes = memBytes;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.TtlSeconds = ttlSeconds;
            this.Vcpus = vcpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateClaimPayload" /> class.
        /// </summary>
        public SandboxesUpdateClaimPayload()
        {
        }
    }
}