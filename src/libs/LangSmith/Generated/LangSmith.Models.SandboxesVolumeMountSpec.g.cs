
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesVolumeMountSpec
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VolumeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeMountSpec" /> class.
        /// </summary>
        /// <param name="mountPath"></param>
        /// <param name="volumeName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesVolumeMountSpec(
            string mountPath,
            string volumeName)
        {
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.VolumeName = volumeName ?? throw new global::System.ArgumentNullException(nameof(volumeName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeMountSpec" /> class.
        /// </summary>
        public SandboxesVolumeMountSpec()
        {
        }
    }
}