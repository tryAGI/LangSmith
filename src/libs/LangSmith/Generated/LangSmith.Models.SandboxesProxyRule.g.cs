
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
        public global::LangSmith.SandboxesProxyAWSConfig? Aws { get; set; }

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
        public global::LangSmith.SandboxesProxyGCPConfig? Gcp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? Headers { get; set; }

        /// <summary>
        /// MatchHosts is only accepted for header injection rules. Provider auth<br/>
        /// rules use built-in host matching.
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
        /// <param name="enabled"></param>
        /// <param name="envVars">
        /// EnvVars are plaintext env vars set for every command in the sandbox while this rule is enabled. Use them for tools that refuse to run unless a credential env var is present (e.g. gh needs GH_TOKEN) even though this rule injects the real credential on the wire — set a dummy value here so the command starts. Explicit per-sandbox env_vars win over these, and provider-managed (AWS/GCP) vars win over both.
        /// </param>
        /// <param name="gcp"></param>
        /// <param name="headers"></param>
        /// <param name="matchHosts">
        /// MatchHosts is only accepted for header injection rules. Provider auth<br/>
        /// rules use built-in host matching.
        /// </param>
        /// <param name="matchPaths"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyRule(
            string name,
            global::LangSmith.SandboxesProxyAWSConfig? aws,
            bool? enabled,
            global::System.Collections.Generic.Dictionary<string, string>? envVars,
            global::LangSmith.SandboxesProxyGCPConfig? gcp,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? headers,
            global::System.Collections.Generic.IList<string>? matchHosts,
            global::System.Collections.Generic.IList<string>? matchPaths,
            string? type)
        {
            this.Aws = aws;
            this.Enabled = enabled;
            this.EnvVars = envVars;
            this.Gcp = gcp;
            this.Headers = headers;
            this.MatchHosts = matchHosts;
            this.MatchPaths = matchPaths;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
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