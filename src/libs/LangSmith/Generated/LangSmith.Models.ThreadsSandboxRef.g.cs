
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ThreadsSandboxRef
    {
        /// <summary>
        /// Example: sandbox-abc123
        /// </summary>
        /// <example>sandbox-abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_slug")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxSlug { get; set; }

        /// <summary>
        /// Example: agent
        /// </summary>
        /// <example>agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsSandboxScopeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ThreadsSandboxScope Scope { get; set; }

        /// <summary>
        /// Example: ready
        /// </summary>
        /// <example>ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ThreadsSandboxStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ThreadsSandboxStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsSandboxRef" /> class.
        /// </summary>
        /// <param name="sandboxSlug">
        /// Example: sandbox-abc123
        /// </param>
        /// <param name="scope">
        /// Example: agent
        /// </param>
        /// <param name="status">
        /// Example: ready
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsSandboxRef(
            string sandboxSlug,
            global::LangSmith.ThreadsSandboxScope scope,
            global::LangSmith.ThreadsSandboxStatus status)
        {
            this.SandboxSlug = sandboxSlug ?? throw new global::System.ArgumentNullException(nameof(sandboxSlug));
            this.Scope = scope;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsSandboxRef" /> class.
        /// </summary>
        public ThreadsSandboxRef()
        {
        }

    }
}