
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSnapshotResponse
    {
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
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_image")]
        public string? DockerImage { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_capacity_bytes")]
        public long? FsCapacityBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_used_bytes")]
        public long? FsUsedBytes { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_digest")]
        public string? ImageDigest { get; set; }

        /// <summary>
        /// The settings this snapshot carries, in include terms: sandboxes created from it start with each one their create request leaves unset. Env var values are never returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("included")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? Included { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// MemorySnapshotSizeBytes is non-nil iff the snapshot was captured with<br/>
        /// VM memory state. A non-nil value is the canonical signal that this<br/>
        /// snapshot can warm-restore from memory; nil means rootfs only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_snapshot_size_bytes")]
        public long? MemorySnapshotSizeBytes { get; set; }

        /// <summary>
        /// The mount_config sandboxes created from this snapshot start with when their create request has none, with secret values redacted. Present only on snapshots captured with include "mounts" or "all" from a sandbox that had mounts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_config")]
        public global::LangSmith.SandboxesSandboxMountConfig? MountConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The proxy_config sandboxes created from this snapshot start with when their create request has none, with secret values redacted. Present only on snapshots captured with include "proxy_config" or "all".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_id")]
        public string? RegistryId { get; set; }

        /// <summary>
        /// RunConfig is what sandboxes from this snapshot boot with. Absent on<br/>
        /// snapshots built before it was recorded, which run as root with their own env.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_config")]
        public global::LangSmith.SandboxapiRunConfig? RunConfig { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_sandbox_id")]
        public string? SourceSandboxId { get; set; }

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
        /// Tags currently resolving to this snapshot, under Name. A snapshot with no<br/>
        /// tags is dangling — addressable only by id.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="createdBy"></param>
        /// <param name="description">
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary.
        /// </param>
        /// <param name="dockerImage"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="fsUsedBytes"></param>
        /// <param name="id"></param>
        /// <param name="imageDigest"></param>
        /// <param name="included">
        /// The settings this snapshot carries, in include terms: sandboxes created from it start with each one their create request leaves unset. Env var values are never returned.
        /// </param>
        /// <param name="labels"></param>
        /// <param name="memorySnapshotSizeBytes">
        /// MemorySnapshotSizeBytes is non-nil iff the snapshot was captured with<br/>
        /// VM memory state. A non-nil value is the canonical signal that this<br/>
        /// snapshot can warm-restore from memory; nil means rootfs only.
        /// </param>
        /// <param name="mountConfig">
        /// The mount_config sandboxes created from this snapshot start with when their create request has none, with secret values redacted. Present only on snapshots captured with include "mounts" or "all" from a sandbox that had mounts.
        /// </param>
        /// <param name="name"></param>
        /// <param name="proxyConfig">
        /// The proxy_config sandboxes created from this snapshot start with when their create request has none, with secret values redacted. Present only on snapshots captured with include "proxy_config" or "all".
        /// </param>
        /// <param name="registryId"></param>
        /// <param name="runConfig">
        /// RunConfig is what sandboxes from this snapshot boot with. Absent on<br/>
        /// snapshots built before it was recorded, which run as root with their own env.
        /// </param>
        /// <param name="sourceSandboxId"></param>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
        /// <param name="tags">
        /// Tags currently resolving to this snapshot, under Name. A snapshot with no<br/>
        /// tags is dangling — addressable only by id.
        /// </param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSnapshotResponse(
            string? createdAt,
            string? createdBy,
            string? description,
            string? dockerImage,
            long? fsCapacityBytes,
            long? fsUsedBytes,
            string? id,
            string? imageDigest,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesSnapshotResponseIncludedItem>? included,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            long? memorySnapshotSizeBytes,
            global::LangSmith.SandboxesSandboxMountConfig? mountConfig,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            string? registryId,
            global::LangSmith.SandboxapiRunConfig? runConfig,
            string? sourceSandboxId,
            string? status,
            string? statusMessage,
            global::System.Collections.Generic.IList<string>? tags,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.Description = description;
            this.DockerImage = dockerImage;
            this.FsCapacityBytes = fsCapacityBytes;
            this.FsUsedBytes = fsUsedBytes;
            this.Id = id;
            this.ImageDigest = imageDigest;
            this.Included = included;
            this.Labels = labels;
            this.MemorySnapshotSizeBytes = memorySnapshotSizeBytes;
            this.MountConfig = mountConfig;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.RegistryId = registryId;
            this.RunConfig = runConfig;
            this.SourceSandboxId = sourceSandboxId;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.Tags = tags;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSnapshotResponse" /> class.
        /// </summary>
        public SandboxesSnapshotResponse()
        {
        }

    }
}