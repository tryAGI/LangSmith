
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesSandboxVolumeResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        public string? MountPath { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_id")]
        public string? VolumeId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        public string? VolumeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxVolumeResponse" /> class.
        /// </summary>
        /// <param name="mountPath"></param>
        /// <param name="readOnly"></param>
        /// <param name="volumeId"></param>
        /// <param name="volumeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesSandboxVolumeResponse(
            string? mountPath,
            bool? readOnly,
            string? volumeId,
            string? volumeName)
        {
            this.MountPath = mountPath;
            this.ReadOnly = readOnly;
            this.VolumeId = volumeId;
            this.VolumeName = volumeName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesSandboxVolumeResponse" /> class.
        /// </summary>
        public SandboxesSandboxVolumeResponse()
        {
        }

    }
}