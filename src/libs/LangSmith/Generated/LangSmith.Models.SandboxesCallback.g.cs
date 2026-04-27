
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesCallback
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_hosts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> MatchHosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? RequestHeaders { get; set; }

        /// <summary>
        /// TTLSeconds is how long resolved headers are cached before the proxy<br/>
        /// re-invokes URL. Must be between 60 and 3600 seconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TtlSeconds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCallback" /> class.
        /// </summary>
        /// <param name="matchHosts"></param>
        /// <param name="ttlSeconds">
        /// TTLSeconds is how long resolved headers are cached before the proxy<br/>
        /// re-invokes URL. Must be between 60 and 3600 seconds.
        /// </param>
        /// <param name="url"></param>
        /// <param name="requestHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCallback(
            global::System.Collections.Generic.IList<string> matchHosts,
            int ttlSeconds,
            string url,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? requestHeaders)
        {
            this.MatchHosts = matchHosts ?? throw new global::System.ArgumentNullException(nameof(matchHosts));
            this.RequestHeaders = requestHeaders;
            this.TtlSeconds = ttlSeconds;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCallback" /> class.
        /// </summary>
        public SandboxesCallback()
        {
        }
    }
}