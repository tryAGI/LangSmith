
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesCreateSnapshotPayload
    {
        /// <summary>
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary. At most 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

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
        /// Labels seed the snapshot's labels, overriding any label of the same key derived from the Docker image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

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
        /// mutable Docker-style tag; defaults to "latest"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        public string? Tag { get; set; }

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
        /// <param name="description">
        /// Description says what this snapshot's image can do, so a caller can hand it to an agent as a capability summary. At most 1024 characters.
        /// </param>
        /// <param name="labels">
        /// Labels seed the snapshot's labels, overriding any label of the same key derived from the Docker image.
        /// </param>
        /// <param name="registryId"></param>
        /// <param name="tag">
        /// mutable Docker-style tag; defaults to "latest"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateSnapshotPayload(
            string dockerImage,
            long fsCapacityBytes,
            string name,
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels,
            string? registryId,
            string? tag)
        {
            this.Description = description;
            this.DockerImage = dockerImage ?? throw new global::System.ArgumentNullException(nameof(dockerImage));
            this.FsCapacityBytes = fsCapacityBytes;
            this.Labels = labels;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RegistryId = registryId;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateSnapshotPayload" /> class.
        /// </summary>
        public SandboxesCreateSnapshotPayload()
        {
        }

    }
}