
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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inject_headers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> InjectHeaders { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MatchHosts { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyRule" /> class.
        /// </summary>
        /// <param name="injectHeaders"></param>
        /// <param name="matchHosts"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="matchPaths"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesProxyRule(
            global::System.Collections.Generic.Dictionary<string, string> injectHeaders,
            global::System.Collections.Generic.IList<string> matchHosts,
            string name,
            bool? enabled,
            global::System.Collections.Generic.IList<string>? matchPaths)
        {
            this.Enabled = enabled;
            this.InjectHeaders = injectHeaders ?? throw new global::System.ArgumentNullException(nameof(injectHeaders));
            this.MatchHosts = matchHosts ?? throw new global::System.ArgumentNullException(nameof(matchHosts));
            this.MatchPaths = matchPaths;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesProxyRule" /> class.
        /// </summary>
        public SandboxesProxyRule()
        {
        }
    }
}