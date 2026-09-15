
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesServiceURLPayload
    {
        /// <summary>
        /// Access selects the login mode, mutually exclusive with the minted token.<br/>
        /// Omit the field for token mode: mint a short-lived service token (default).<br/>
        ///   "restricted" — LangSmith login: any user with SandboxesRead on the sandbox.<br/>
        ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
        ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
        /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesServiceURLPayloadAccessJsonConverter))]
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Access { get; set; }

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
        /// <param name="access">
        /// Access selects the login mode, mutually exclusive with the minted token.<br/>
        /// Omit the field for token mode: mint a short-lived service token (default).<br/>
        ///   "restricted" — LangSmith login: any user with SandboxesRead on the sandbox.<br/>
        ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
        ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
        /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
        /// </param>
        /// <param name="expiresInSeconds"></param>
        /// <param name="port"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLPayload(
            global::LangSmith.SandboxesServiceURLPayloadAccess? access,
            int? expiresInSeconds,
            int? port)
        {
            this.Access = access;
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