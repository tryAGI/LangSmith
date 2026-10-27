
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesStartSandboxPayload
    {
        /// <summary>
        /// DiscardMemory cold-boots the sandbox, discarding any memory saved when it stopped.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discard_memory")]
        public bool? DiscardMemory { get; set; }

        /// <summary>
        /// Volumes, when present, replaces the attached volumes. A start whose volumes differ from those the sandbox's saved memory was captured with fails unless discard_memory is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volumes")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? Volumes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesStartSandboxPayload" /> class.
        /// </summary>
        /// <param name="discardMemory">
        /// DiscardMemory cold-boots the sandbox, discarding any memory saved when it stopped.
        /// </param>
        /// <param name="volumes">
        /// Volumes, when present, replaces the attached volumes. A start whose volumes differ from those the sandbox's saved memory was captured with fails unless discard_memory is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesStartSandboxPayload(
            bool? discardMemory,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountRequest>? volumes)
        {
            this.DiscardMemory = discardMemory;
            this.Volumes = volumes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesStartSandboxPayload" /> class.
        /// </summary>
        public SandboxesStartSandboxPayload()
        {
        }

    }
}