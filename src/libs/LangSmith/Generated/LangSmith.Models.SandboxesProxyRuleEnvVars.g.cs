
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// EnvVars are plaintext env vars set for every command in the sandbox while this rule is enabled. Use them for tools that refuse to run unless a credential env var is present (e.g. gh needs GH_TOKEN) even though this rule injects the real credential on the wire — set a dummy value here so the command starts. Explicit per-sandbox env_vars win over these, and provider-managed (AWS/GCP) vars win over both.
    /// </summary>
    public sealed partial class SandboxesProxyRuleEnvVars
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}