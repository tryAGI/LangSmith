
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesVolumeAttachmentResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_id")]
        public string? SandboxId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_name")]
        public string? SandboxName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeAttachmentResponse" /> class.
        /// </summary>
        /// <param name="mountPath"></param>
        /// <param name="readOnly"></param>
        /// <param name="sandboxId"></param>
        /// <param name="sandboxName"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesVolumeAttachmentResponse(
            string? mountPath,
            bool? readOnly,
            string? sandboxId,
            string? sandboxName)
        {
            this.MountPath = mountPath;
            this.ReadOnly = readOnly;
            this.SandboxId = sandboxId;
            this.SandboxName = sandboxName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesVolumeAttachmentResponse" /> class.
        /// </summary>
        public SandboxesVolumeAttachmentResponse()
        {
        }

    }
}