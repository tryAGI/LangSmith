
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
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_name")]
        public string? SnapshotName { get; set; }

        /// <summary>
        /// required for Kata path
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public string? TemplateName { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("vcpus")]
        public int? Vcpus { get; set; }

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
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="templateName">
        /// required for Kata path
        /// </param>
        /// <param name="timeout"></param>
        /// <param name="ttlSeconds"></param>
        /// <param name="vcpus"></param>
        /// <param name="waitForReady"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateClaimPayload(
            long? fsCapacityBytes,
            int? idleTtlSeconds,
            long? memBytes,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            string? snapshotId,
            string? snapshotName,
            string? templateName,
            int? timeout,
            int? ttlSeconds,
            int? vcpus,
            bool? waitForReady)
        {
            this.FsCapacityBytes = fsCapacityBytes;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.MemBytes = memBytes;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.SnapshotId = snapshotId;
            this.SnapshotName = snapshotName;
            this.TemplateName = templateName;
            this.Timeout = timeout;
            this.TtlSeconds = ttlSeconds;
            this.Vcpus = vcpus;
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