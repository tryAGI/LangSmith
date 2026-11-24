
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AuthnSandboxCreateRateLimit
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("burst")]
        public int? Burst { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_second")]
        public int? PerSecond { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnSandboxCreateRateLimit" /> class.
        /// </summary>
        /// <param name="burst"></param>
        /// <param name="perSecond"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthnSandboxCreateRateLimit(
            int? burst,
            int? perSecond)
        {
            this.Burst = burst;
            this.PerSecond = perSecond;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnSandboxCreateRateLimit" /> class.
        /// </summary>
        public AuthnSandboxCreateRateLimit()
        {
        }

    }
}