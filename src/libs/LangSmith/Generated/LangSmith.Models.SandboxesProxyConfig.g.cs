
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
        [global::System.Text.Json.Serialization.JsonPropertyName("access_control")]
        public global::LangSmith.SandboxesAccessControl? AccessControl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("no_proxy")]
        public global::System.Collections.Generic.IList<string>? NoProxy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rules")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? Rules { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyConfig" /> class.
        /// </summary>
        /// <param name="accessControl"></param>
        /// <param name="noProxy"></param>
        /// <param name="rules"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyConfig(
            global::LangSmith.SandboxesAccessControl? accessControl,
            global::System.Collections.Generic.IList<string>? noProxy,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyRule>? rules)
        {
            this.AccessControl = accessControl;
            this.NoProxy = noProxy;
            this.Rules = rules;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyConfig" /> class.
        /// </summary>
        public SandboxesProxyConfig()
        {
        }
    }
}