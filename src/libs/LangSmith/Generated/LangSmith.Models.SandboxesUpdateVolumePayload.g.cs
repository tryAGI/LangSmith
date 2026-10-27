
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesUpdateVolumePayload
    {
        /// <summary>
        /// Description replaces the description; null or an empty string clears it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Labels replaces every label; null or an empty object clears them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public global::System.Collections.Generic.Dictionary<string, string>? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateVolumePayload" /> class.
        /// </summary>
        /// <param name="description">
        /// Description replaces the description; null or an empty string clears it.
        /// </param>
        /// <param name="labels">
        /// Labels replaces every label; null or an empty object clears them.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesUpdateVolumePayload(
            string? description,
            global::System.Collections.Generic.Dictionary<string, string>? labels)
        {
            this.Description = description;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesUpdateVolumePayload" /> class.
        /// </summary>
        public SandboxesUpdateVolumePayload()
        {
        }

    }
}