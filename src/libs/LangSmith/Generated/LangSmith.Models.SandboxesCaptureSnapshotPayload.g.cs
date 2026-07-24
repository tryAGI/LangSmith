
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCaptureSnapshotPayload
    {
        /// <summary>
        /// if omitted, creates a fresh checkpoint from the running VM
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoint")]
        public string? Checkpoint { get; set; }

        /// <summary>
        /// sandbox-local Docker image to export
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("docker_image")]
        public string? DockerImage { get; set; }

        /// <summary>
        /// required for Docker image export unless the sandbox has a capacity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fs_capacity_bytes")]
        public long? FsCapacityBytes { get; set; }

        /// <summary>
        /// IncludeMemory, when true, captures a full VM memory snapshot<br/>
        /// alongside the filesystem clone. Only honored when the sandbox is running<br/>
        /// AND Checkpoint is omitted (i.e. a fresh in-VM checkpoint is requested).<br/>
        /// Defaults to false to keep snapshots small unless memory restore is<br/>
        /// explicitly desired.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_memory")]
        public bool? IncludeMemory { get; set; }

        /// <summary>
        /// Labels seed the captured snapshot's labels.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCaptureSnapshotPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="checkpoint">
        /// if omitted, creates a fresh checkpoint from the running VM
        /// </param>
        /// <param name="dockerImage">
        /// sandbox-local Docker image to export
        /// </param>
        /// <param name="fsCapacityBytes">
        /// required for Docker image export unless the sandbox has a capacity
        /// </param>
        /// <param name="includeMemory">
        /// IncludeMemory, when true, captures a full VM memory snapshot<br/>
        /// alongside the filesystem clone. Only honored when the sandbox is running<br/>
        /// AND Checkpoint is omitted (i.e. a fresh in-VM checkpoint is requested).<br/>
        /// Defaults to false to keep snapshots small unless memory restore is<br/>
        /// explicitly desired.
        /// </param>
        /// <param name="labels">
        /// Labels seed the captured snapshot's labels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCaptureSnapshotPayload(
            string name,
            string? checkpoint,
            string? dockerImage,
            long? fsCapacityBytes,
            bool? includeMemory,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Checkpoint = checkpoint;
            this.DockerImage = dockerImage;
            this.FsCapacityBytes = fsCapacityBytes;
            this.IncludeMemory = includeMemory;
            this.Labels = labels;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCaptureSnapshotPayload" /> class.
        /// </summary>
        public SandboxesCaptureSnapshotPayload()
        {
        }

    }
}