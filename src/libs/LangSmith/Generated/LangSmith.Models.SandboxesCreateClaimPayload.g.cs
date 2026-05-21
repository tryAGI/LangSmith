
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
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_stop_seconds")]
        public int? DeleteAfterStopSeconds { get; set; }

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
        /// RestoreMemory, when non-nil, overrides the server default for<br/>
        /// whether to resume the sandbox from its captured memory snapshot.<br/>
        ///   true  → resume from the memory snapshot if it exists; cold-boot<br/>
        ///           the sandbox otherwise.<br/>
        ///   false → always cold-boot, even if a memory snapshot exists.<br/>
        ///   nil   → use the server default.<br/>
        /// Applies to this request only; a later stop+start of the same<br/>
        /// sandbox reverts to the server default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore_memory")]
        public bool? RestoreMemory { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag_value_ids")]
        public global::System.Collections.Generic.IList<string>? TagValueIds { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesCreateClaimPayload" /> class.
        /// </summary>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="memBytes"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="restoreMemory">
        /// RestoreMemory, when non-nil, overrides the server default for<br/>
        /// whether to resume the sandbox from its captured memory snapshot.<br/>
        ///   true  → resume from the memory snapshot if it exists; cold-boot<br/>
        ///           the sandbox otherwise.<br/>
        ///   false → always cold-boot, even if a memory snapshot exists.<br/>
        ///   nil   → use the server default.<br/>
        /// Applies to this request only; a later stop+start of the same<br/>
        /// sandbox reverts to the server default.
        /// </param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="vcpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateClaimPayload(
            int? deleteAfterStopSeconds,
            long? fsCapacityBytes,
            int? idleTtlSeconds,
            long? memBytes,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            bool? restoreMemory,
            string? snapshotId,
            string? snapshotName,
            global::System.Collections.Generic.IList<string>? tagValueIds,
            int? vcpus)
        {
            this.DeleteAfterStopSeconds = deleteAfterStopSeconds;
            this.FsCapacityBytes = fsCapacityBytes;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.MemBytes = memBytes;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.RestoreMemory = restoreMemory;
            this.SnapshotId = snapshotId;
            this.SnapshotName = snapshotName;
            this.TagValueIds = tagValueIds;
            this.Vcpus = vcpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateClaimPayload" /> class.
        /// </summary>
        public SandboxesCreateClaimPayload()
        {
        }

    }
}