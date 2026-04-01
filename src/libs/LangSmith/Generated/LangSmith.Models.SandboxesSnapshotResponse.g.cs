
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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_id")]
        public string? RegistryId { get; set; }

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
        /// <param name="dockerImage"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="fsUsedBytes"></param>
        /// <param name="id"></param>
        /// <param name="imageDigest"></param>
        /// <param name="name"></param>
        /// <param name="registryId"></param>
        /// <param name="sourceSandboxId"></param>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSnapshotResponse(
            string? createdAt,
            string? createdBy,
            string? dockerImage,
            long? fsCapacityBytes,
            long? fsUsedBytes,
            string? id,
            string? imageDigest,
            string? name,
            string? registryId,
            string? sourceSandboxId,
            string? status,
            string? statusMessage,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.DockerImage = dockerImage;
            this.FsCapacityBytes = fsCapacityBytes;
            this.FsUsedBytes = fsUsedBytes;
            this.Id = id;
            this.ImageDigest = imageDigest;
            this.Name = name;
            this.RegistryId = registryId;
            this.SourceSandboxId = sourceSandboxId;
            this.Status = status;
            this.StatusMessage = statusMessage;
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