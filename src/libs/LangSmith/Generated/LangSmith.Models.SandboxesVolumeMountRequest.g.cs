
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesVolumeMountRequest
    {
        /// <summary>
        /// MountPath is the absolute directory inside the sandbox where the volume appears.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mount_path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MountPath { get; set; }

        /// <summary>
        /// ReadOnly mounts the volume read-only; many sandboxes may do so at once.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_only")]
        public bool? ReadOnly { get; set; }

        /// <summary>
        /// Volume is the volume's ID or name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Volume { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeMountRequest" /> class.
        /// </summary>
        /// <param name="mountPath">
        /// MountPath is the absolute directory inside the sandbox where the volume appears.
        /// </param>
        /// <param name="volume">
        /// Volume is the volume's ID or name.
        /// </param>
        /// <param name="readOnly">
        /// ReadOnly mounts the volume read-only; many sandboxes may do so at once.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesVolumeMountRequest(
            string mountPath,
            string volume,
            bool? readOnly)
        {
            this.MountPath = mountPath ?? throw new global::System.ArgumentNullException(nameof(mountPath));
            this.ReadOnly = readOnly;
            this.Volume = volume ?? throw new global::System.ArgumentNullException(nameof(volume));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeMountRequest" /> class.
        /// </summary>
        public SandboxesVolumeMountRequest()
        {
        }

    }
}