
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesSandboxResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_millicores")]
        public int? CpuMillicores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataplane_url")]
        public string? DataplaneUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idle_ttl_seconds")]
        public int? IdleTtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mem_bytes")]
        public long? MemBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_config")]
        public global::LangSmith.SandboxesSandboxMountConfig? MountConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_memory_on_stop")]
        public bool? PreserveMemoryOnStop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_class")]
        public string? SizeClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_id")]
        public string? SnapshotId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopped_at")]
        public string? StoppedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_by")]
        public string? UpdatedBy { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesSandboxResponse" /> class.
        /// </summary>
        /// <param name="cpuMillicores"></param>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="dataplaneUrl"></param>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="id"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="labels"></param>
        /// <param name="memBytes"></param>
        /// <param name="mountConfig"></param>
        /// <param name="name"></param>
        /// <param name="preserveMemoryOnStop"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="sizeClass"></param>
        /// <param name="snapshotId"></param>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
        /// <param name="stoppedAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="updatedBy"></param>
        /// <param name="vcpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxResponse(
            int? cpuMillicores,
            string? createdAt,
            string? createdBy,
            string? dataplaneUrl,
            int? deleteAfterStopSeconds,
            long? fsCapacityBytes,
            string? id,
            int? idleTtlSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            long? memBytes,
            global::LangSmith.SandboxesSandboxMountConfig? mountConfig,
            string? name,
            bool? preserveMemoryOnStop,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            string? sizeClass,
            string? snapshotId,
            string? status,
            string? statusMessage,
            string? stoppedAt,
            string? updatedAt,
            string? updatedBy,
            int? vcpus)
        {
            this.CpuMillicores = cpuMillicores;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DataplaneUrl = dataplaneUrl;
            this.DeleteAfterStopSeconds = deleteAfterStopSeconds;
            this.FsCapacityBytes = fsCapacityBytes;
            this.Id = id;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.Labels = labels;
            this.MemBytes = memBytes;
            this.MountConfig = mountConfig;
            this.Name = name;
            this.PreserveMemoryOnStop = preserveMemoryOnStop;
            this.ProxyConfig = proxyConfig;
            this.SizeClass = sizeClass;
            this.SnapshotId = snapshotId;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.StoppedAt = stoppedAt;
            this.UpdatedAt = updatedAt;
            this.UpdatedBy = updatedBy;
            this.Vcpus = vcpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxResponse" /> class.
        /// </summary>
        public SandboxesSandboxResponse()
        {
        }

    }
}