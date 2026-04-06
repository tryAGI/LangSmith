
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesServiceURLPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        public int? Port { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLPayload" /> class.
        /// </summary>
        /// <param name="expiresInSeconds"></param>
        /// <param name="port"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLPayload(
            int? expiresInSeconds,
            int? port)
        {
            this.ExpiresInSeconds = expiresInSeconds;
            this.Port = port;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesServiceURLPayload" /> class.
        /// </summary>
        public SandboxesServiceURLPayload()
        {
        }
    }
}