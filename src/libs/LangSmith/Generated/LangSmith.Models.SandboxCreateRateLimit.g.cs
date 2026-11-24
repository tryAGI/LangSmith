
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A sandbox create rate.
    /// </summary>
    public sealed partial class SandboxCreateRateLimit
    {
        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_second")]
        public int? PerSecond { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("burst")]
        public int? Burst { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxCreateRateLimit" /> class.
        /// </summary>
        /// <param name="perSecond">
        /// Default Value: 0
        /// </param>
        /// <param name="burst">
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxCreateRateLimit(
            int? perSecond,
            int? burst)
        {
            this.PerSecond = perSecond;
            this.Burst = burst;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxCreateRateLimit" /> class.
        /// </summary>
        public SandboxCreateRateLimit()
        {
        }

    }
}