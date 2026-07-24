
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreateSandboxPayload
    {
        /// <summary>
        /// CPUMillicores optionally requests CPU at millicore granularity (e.g. 500 = 0.5 vCPU); takes precedence over VCPUs. Fractional (sub-vCPU) values are not available for every sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpu_millicores")]
        public int? CpuMillicores { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delete_after_stop_seconds")]
        public int? DeleteAfterStopSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

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
        /// Labels are free-form key/value metadata persisted with the sandbox and returned on reads. Labels from the source snapshot are inherited unless overridden here.
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
        /// PreserveMemoryOnStop, when true, suspends the sandbox's memory on a<br/>
        /// voluntary stop (idle timeout or explicit stop) so the next start resumes<br/>
        /// from where it left off. Default false discards memory and keeps only the<br/>
        /// filesystem, so the next start is a cold boot. Restarts triggered by<br/>
        /// infrastructure maintenance always preserve memory regardless of this setting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preserve_memory_on_stop")]
        public bool? PreserveMemoryOnStop { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// RestoreMemory selects how the sandbox handles a snapshot's captured memory:<br/>
        ///   nil   → if-present: resume from memory when the snapshot has it, else cold-boot (default).<br/>
        ///   true  → always: resume from memory; rejected if the snapshot has none.<br/>
        ///   false → never: always cold-boot.<br/>
        /// Applies to this request only.
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
        /// Initializes a new instance of the <see cref="SandboxesCreateSandboxPayload" /> class.
        /// </summary>
        /// <param name="cpuMillicores">
        /// CPUMillicores optionally requests CPU at millicore granularity (e.g. 500 = 0.5 vCPU); takes precedence over VCPUs. Fractional (sub-vCPU) values are not available for every sandbox.
        /// </param>
        /// <param name="deleteAfterStopSeconds"></param>
        /// <param name="envVars"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="idleTtlSeconds"></param>
        /// <param name="labels">
        /// Labels are free-form key/value metadata persisted with the sandbox and returned on reads. Labels from the source snapshot are inherited unless overridden here.
        /// </param>
        /// <param name="memBytes"></param>
        /// <param name="mountConfig"></param>
        /// <param name="name"></param>
        /// <param name="preserveMemoryOnStop">
        /// PreserveMemoryOnStop, when true, suspends the sandbox's memory on a<br/>
        /// voluntary stop (idle timeout or explicit stop) so the next start resumes<br/>
        /// from where it left off. Default false discards memory and keeps only the<br/>
        /// filesystem, so the next start is a cold boot. Restarts triggered by<br/>
        /// infrastructure maintenance always preserve memory regardless of this setting.
        /// </param>
        /// <param name="proxyConfig"></param>
        /// <param name="restoreMemory">
        /// RestoreMemory selects how the sandbox handles a snapshot's captured memory:<br/>
        ///   nil   → if-present: resume from memory when the snapshot has it, else cold-boot (default).<br/>
        ///   true  → always: resume from memory; rejected if the snapshot has none.<br/>
        ///   false → never: always cold-boot.<br/>
        /// Applies to this request only.
        /// </param>
        /// <param name="snapshotId"></param>
        /// <param name="snapshotName"></param>
        /// <param name="tagValueIds"></param>
        /// <param name="vcpus"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateSandboxPayload(
            int? cpuMillicores,
            int? deleteAfterStopSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            long? fsCapacityBytes,
            int? idleTtlSeconds,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            long? memBytes,
            global::LangSmith.SandboxesSandboxMountConfig? mountConfig,
            string? name,
            bool? preserveMemoryOnStop,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            bool? restoreMemory,
            string? snapshotId,
            string? snapshotName,
            global::System.Collections.Generic.IList<string>? tagValueIds,
            int? vcpus)
        {
            this.CpuMillicores = cpuMillicores;
            this.DeleteAfterStopSeconds = deleteAfterStopSeconds;
            this.EnvVars = envVars;
            this.FsCapacityBytes = fsCapacityBytes;
            this.IdleTtlSeconds = idleTtlSeconds;
            this.Labels = labels;
            this.MemBytes = memBytes;
            this.MountConfig = mountConfig;
            this.Name = name;
            this.PreserveMemoryOnStop = preserveMemoryOnStop;
            this.ProxyConfig = proxyConfig;
            this.RestoreMemory = restoreMemory;
            this.SnapshotId = snapshotId;
            this.SnapshotName = snapshotName;
            this.TagValueIds = tagValueIds;
            this.Vcpus = vcpus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSandboxPayload" /> class.
        /// </summary>
        public SandboxesCreateSandboxPayload()
        {
        }

    }
}