
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCreateSnapshotPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DockerImage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_capacity_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long FsCapacityBytes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_id")]
        public string? RegistryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_password")]
        public string? RegistryPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_url")]
        public string? RegistryUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_username")]
        public string? RegistryUsername { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSnapshotPayload" /> class.
        /// </summary>
        /// <param name="dockerImage"></param>
        /// <param name="fsCapacityBytes"></param>
        /// <param name="name"></param>
        /// <param name="registryId"></param>
        /// <param name="registryPassword"></param>
        /// <param name="registryUrl"></param>
        /// <param name="registryUsername"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateSnapshotPayload(
            string dockerImage,
            long fsCapacityBytes,
            string name,
            string? registryId,
            string? registryPassword,
            string? registryUrl,
            string? registryUsername)
        {
            this.DockerImage = dockerImage ?? throw new global::System.ArgumentNullException(nameof(dockerImage));
            this.FsCapacityBytes = fsCapacityBytes;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RegistryId = registryId;
            this.RegistryPassword = registryPassword;
            this.RegistryUrl = registryUrl;
            this.RegistryUsername = registryUsername;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSnapshotPayload" /> class.
        /// </summary>
        public SandboxesCreateSnapshotPayload()
        {
        }
    }
}