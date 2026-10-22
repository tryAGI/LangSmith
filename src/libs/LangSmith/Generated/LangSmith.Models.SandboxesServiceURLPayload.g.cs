
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
        ///   "restricted" — LangSmith login: the sandbox's creator, or any user with SandboxesExec on it (admins by default).<br/>
        ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
        ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
        /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesServiceURLPayloadAccessJsonConverter))]
        public global::LangSmith.SandboxesServiceURLPayloadAccess? Access { get; set; }

        /// <summary>
        /// EmbedOrigins are the pages allowed to show a LangSmith login service URL<br/>
        /// in an iframe, besides LangSmith itself: at most 5 origins such as<br/>
        /// https://app.example.com (http only for localhost). Valid only with access<br/>
        /// "restricted" or "workspace". Each call sets the URL's whole list, so<br/>
        /// omitting the field removes any origins set before.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_origins")]
        public global::System.Collections.Generic.IList<string>? EmbedOrigins { get; set; }

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
        ///   "restricted" — LangSmith login: the sandbox's creator, or any user with SandboxesExec on it (admins by default).<br/>
        ///   "workspace"  — LangSmith login: any member of the owning workspace.<br/>
        ///   "off"        — remove an existing LangSmith login grant and mint a token.<br/>
        /// A LangSmith login grant is durable; token mode is refused (409) while one exists.
        /// </param>
        /// <param name="embedOrigins">
        /// EmbedOrigins are the pages allowed to show a LangSmith login service URL<br/>
        /// in an iframe, besides LangSmith itself: at most 5 origins such as<br/>
        /// https://app.example.com (http only for localhost). Valid only with access<br/>
        /// "restricted" or "workspace". Each call sets the URL's whole list, so<br/>
        /// omitting the field removes any origins set before.
        /// </param>
        /// <param name="expiresInSeconds"></param>
        /// <param name="port"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesServiceURLPayload(
            global::LangSmith.SandboxesServiceURLPayloadAccess? access,
            global::System.Collections.Generic.IList<string>? embedOrigins,
            int? expiresInSeconds,
            int? port)
        {
            this.Access = access;
            this.EmbedOrigins = embedOrigins;
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