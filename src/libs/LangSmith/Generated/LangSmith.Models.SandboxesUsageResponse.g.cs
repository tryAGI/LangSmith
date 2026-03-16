
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesUsageResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_limit_millicores")]
        public int? CpuLimitMillicores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_used_millicores")]
        public int? CpuUsedMillicores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit_bytes")]
        public long? MemoryLimitBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_used_bytes")]
        public long? MemoryUsedBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pools_count")]
        public int? PoolsCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registries_count")]
        public int? RegistriesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_direct_count")]
        public int? SandboxDirectCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_pool_replicas_count")]
        public int? SandboxPoolReplicasCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes_limit")]
        public int? SandboxesLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandboxes_used")]
        public int? SandboxesUsed { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_limit_bytes")]
        public long? StorageLimitBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("storage_used_bytes")]
        public long? StorageUsedBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("templates_count")]
        public int? TemplatesCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes_limit")]
        public int? VolumesLimit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes_used")]
        public int? VolumesUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUsageResponse" /> class.
        /// </summary>
        /// <param name="cpuLimitMillicores"></param>
        /// <param name="cpuUsedMillicores"></param>
        /// <param name="memoryLimitBytes"></param>
        /// <param name="memoryUsedBytes"></param>
        /// <param name="poolsCount"></param>
        /// <param name="registriesCount"></param>
        /// <param name="sandboxDirectCount"></param>
        /// <param name="sandboxPoolReplicasCount"></param>
        /// <param name="sandboxesLimit"></param>
        /// <param name="sandboxesUsed"></param>
        /// <param name="storageLimitBytes"></param>
        /// <param name="storageUsedBytes"></param>
        /// <param name="templatesCount"></param>
        /// <param name="volumesLimit"></param>
        /// <param name="volumesUsed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUsageResponse(
            int? cpuLimitMillicores,
            int? cpuUsedMillicores,
            long? memoryLimitBytes,
            long? memoryUsedBytes,
            int? poolsCount,
            int? registriesCount,
            int? sandboxDirectCount,
            int? sandboxPoolReplicasCount,
            int? sandboxesLimit,
            int? sandboxesUsed,
            long? storageLimitBytes,
            long? storageUsedBytes,
            int? templatesCount,
            int? volumesLimit,
            int? volumesUsed)
        {
            this.CpuLimitMillicores = cpuLimitMillicores;
            this.CpuUsedMillicores = cpuUsedMillicores;
            this.MemoryLimitBytes = memoryLimitBytes;
            this.MemoryUsedBytes = memoryUsedBytes;
            this.PoolsCount = poolsCount;
            this.RegistriesCount = registriesCount;
            this.SandboxDirectCount = sandboxDirectCount;
            this.SandboxPoolReplicasCount = sandboxPoolReplicasCount;
            this.SandboxesLimit = sandboxesLimit;
            this.SandboxesUsed = sandboxesUsed;
            this.StorageLimitBytes = storageLimitBytes;
            this.StorageUsedBytes = storageUsedBytes;
            this.TemplatesCount = templatesCount;
            this.VolumesLimit = volumesLimit;
            this.VolumesUsed = volumesUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUsageResponse" /> class.
        /// </summary>
        public SandboxesUsageResponse()
        {
        }
    }
}