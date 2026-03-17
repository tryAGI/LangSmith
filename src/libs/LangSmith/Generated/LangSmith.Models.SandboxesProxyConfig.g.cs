
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesProxyConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_proxy")]
        public global::System.Collections.Generic.IList<string>? NoProxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule> Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyConfig" /> class.
        /// </summary>
        /// <param name="noProxy"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyConfig(
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule> rules,
            global::System.Collections.Generic.IList<string>? noProxy)
        {
            this.Rules = rules ?? throw new global::System.ArgumentNullException(nameof(rules));
            this.NoProxy = noProxy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyConfig" /> class.
        /// </summary>
        public SandboxesProxyConfig()
        {
        }
    }
}