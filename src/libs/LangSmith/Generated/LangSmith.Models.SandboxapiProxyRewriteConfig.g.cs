
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxapiProxyRewriteConfig
    {
        /// <summary>
        /// Credentials is what happens to credential headers the sandbox sent, such as Authorization and Cookie: "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("credentials")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxapiProxyRewriteConfigCredentialsJsonConverter))]
        public global::LangSmith.SandboxapiProxyRewriteConfigCredentials? Credentials { get; set; }

        /// <summary>
        /// Host is an HTTPS destination. Exactly one of host and sandbox is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        public string? Host { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("port")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Port { get; set; }

        /// <summary>
        /// Sandbox is the name or ID of a sandbox to send requests to, over plain HTTP. A sandbox link from this sandbox to that sandbox's port must exist. Exactly one of host and sandbox is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public string? Sandbox { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiProxyRewriteConfig" /> class.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="credentials">
        /// Credentials is what happens to credential headers the sandbox sent, such as Authorization and Cookie: "strip" (the default) removes them, "redact" keeps each with its value replaced by "redacted" (after an auth scheme such as "Bearer "), and "keep" forwards them unchanged.
        /// </param>
        /// <param name="host">
        /// Host is an HTTPS destination. Exactly one of host and sandbox is set.
        /// </param>
        /// <param name="sandbox">
        /// Sandbox is the name or ID of a sandbox to send requests to, over plain HTTP. A sandbox link from this sandbox to that sandbox's port must exist. Exactly one of host and sandbox is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxapiProxyRewriteConfig(
            int port,
            global::LangSmith.SandboxapiProxyRewriteConfigCredentials? credentials,
            string? host,
            string? sandbox)
        {
            this.Credentials = credentials;
            this.Host = host;
            this.Port = port;
            this.Sandbox = sandbox;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxapiProxyRewriteConfig" /> class.
        /// </summary>
        public SandboxapiProxyRewriteConfig()
        {
        }

    }
}