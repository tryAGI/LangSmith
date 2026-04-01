
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCaptureSnapshotPayload(
            string name,
            string? checkpoint)
        {
            this.Checkpoint = checkpoint;
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