
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesProxyRule
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesProxyAWSConfigJsonConverter))]
        public global::LangSmith.SandboxesProxyAWSConfig? Aws { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("azure")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesProxyAzureConfigJsonConverter))]
        public global::LangSmith.SandboxesProxyAzureConfig? Azure { get; set; }

        /// <summary>
        /// Description says what this rule lets the sandbox reach, so an agent driving the sandbox can be told its capabilities. At most 1024 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// EnvVars are plaintext env vars set for every command in the sandbox while this rule is enabled. Use them for tools that refuse to run unless a credential env var is present (e.g. gh needs GH_TOKEN) even though this rule injects the real credential on the wire — set a dummy value here so the command starts. Explicit per-sandbox env_vars win over these, and provider-managed (AWS/GCP) vars win over both.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("env_vars")]
        public global::System.Collections.Generic.Dictionary<string, string>? EnvVars { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gcp")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesProxyGCPConfigJsonConverter))]
        public global::LangSmith.SandboxesProxyGCPConfig? Gcp { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Headers { get; set; }

        /// <summary>
        /// MatchHeaders restricts a header injection or rewrite rule to requests carrying every listed header, each written "name: value" with a lowercase name and an exact value. Pair with headers of the same name to swap a placeholder the sandbox sends (e.g. "authorization: Bearer account-b") for a real credential, so one host can serve several accounts. Rules are evaluated in order and the first match wins.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_headers")]
        public global::System.Collections.Generic.IList<string>? MatchHeaders { get; set; }

        /// <summary>
        /// MatchHosts is only accepted for header injection, rewrite, and relay rules.<br/>
        /// Provider auth rules use built-in host matching. A relay rule may also<br/>
        /// list IP addresses and CIDR blocks (10.0.0.0/8), which match connections<br/>
        /// the sandbox makes to an IP address rather than a name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_hosts")]
        public global::System.Collections.Generic.IList<string>? MatchHosts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_paths")]
        public global::System.Collections.Generic.IList<string>? MatchPaths { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// RelayID is the ID of the LangSmith relay (a connection of kind relay) that carries connections to match_hosts when type is relay. Those connections leave from the relay's connector, and its network and IP, instead of the sandbox host. Access control still applies first, the first enabled matching relay rule wins, and a matched host never falls back to a direct connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relay_id")]
        public global::System.Guid? RelayId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rewrite")]
        public global::LangSmith.SandboxapiProxyRewriteConfig? Rewrite { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyRule" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="aws"></param>
        /// <param name="azure"></param>
        /// <param name="description">
        /// Description says what this rule lets the sandbox reach, so an agent driving the sandbox can be told its capabilities. At most 1024 characters.
        /// </param>
        /// <param name="enabled"></param>
        /// <param name="envVars">
        /// EnvVars are plaintext env vars set for every command in the sandbox while this rule is enabled. Use them for tools that refuse to run unless a credential env var is present (e.g. gh needs GH_TOKEN) even though this rule injects the real credential on the wire — set a dummy value here so the command starts. Explicit per-sandbox env_vars win over these, and provider-managed (AWS/GCP) vars win over both.
        /// </param>
        /// <param name="gcp"></param>
        /// <param name="headers"></param>
        /// <param name="matchHeaders">
        /// MatchHeaders restricts a header injection or rewrite rule to requests carrying every listed header, each written "name: value" with a lowercase name and an exact value. Pair with headers of the same name to swap a placeholder the sandbox sends (e.g. "authorization: Bearer account-b") for a real credential, so one host can serve several accounts. Rules are evaluated in order and the first match wins.
        /// </param>
        /// <param name="matchHosts">
        /// MatchHosts is only accepted for header injection, rewrite, and relay rules.<br/>
        /// Provider auth rules use built-in host matching. A relay rule may also<br/>
        /// list IP addresses and CIDR blocks (10.0.0.0/8), which match connections<br/>
        /// the sandbox makes to an IP address rather than a name.
        /// </param>
        /// <param name="matchPaths"></param>
        /// <param name="relayId">
        /// RelayID is the ID of the LangSmith relay (a connection of kind relay) that carries connections to match_hosts when type is relay. Those connections leave from the relay's connector, and its network and IP, instead of the sandbox host. Access control still applies first, the first enabled matching relay rule wins, and a matched host never falls back to a direct connection.
        /// </param>
        /// <param name="rewrite"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyRule(
            string name,
            global::LangSmith.SandboxesProxyAWSConfig? aws,
            global::LangSmith.SandboxesProxyAzureConfig? azure,
            string? description,
            bool? enabled,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            global::LangSmith.SandboxesProxyGCPConfig? gcp,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? headers,
            global::System.Collections.Generic.IList<string>? matchHeaders,
            global::System.Collections.Generic.IList<string>? matchHosts,
            global::System.Collections.Generic.IList<string>? matchPaths,
            global::System.Guid? relayId,
            global::LangSmith.SandboxapiProxyRewriteConfig? rewrite,
            string? type)
        {
            this.Aws = aws;
            this.Azure = azure;
            this.Description = description;
            this.Enabled = enabled;
            this.EnvVars = envVars;
            this.Gcp = gcp;
            this.Headers = headers;
            this.MatchHeaders = matchHeaders;
            this.MatchHosts = matchHosts;
            this.MatchPaths = matchPaths;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.RelayId = relayId;
            this.Rewrite = rewrite;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyRule" /> class.
        /// </summary>
        public SandboxesProxyRule()
        {
        }

    }
}