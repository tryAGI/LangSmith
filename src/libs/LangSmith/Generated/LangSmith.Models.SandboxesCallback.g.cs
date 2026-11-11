
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesCallback
    {
        /// <summary>
        /// AttributionHeaders selects required all-egress response headers instead of destination credentials; omit match_hosts and full_request, and return expires_at with the headers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attribution_headers")]
        public global::System.Collections.Generic.IList<string>? AttributionHeaders { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("full_request")]
        public bool? FullRequest { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("match_hosts")]
        public global::System.Collections.Generic.IList<string>? MatchHosts { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_headers")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? RequestHeaders { get; set; }

        /// <summary>
        ///
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
        /// <param name="ttlSeconds"></param>
        /// <param name="url"></param>
        /// <param name="attributionHeaders">
        /// AttributionHeaders selects required all-egress response headers instead of destination credentials; omit match_hosts and full_request, and return expires_at with the headers.
        /// </param>
        /// <param name="fullRequest"></param>
        /// <param name="matchHosts"></param>
        /// <param name="requestHeaders"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCallback(
            int ttlSeconds,
            string url,
            global::System.Collections.Generic.IList<string>? attributionHeaders,
            bool? fullRequest,
            global::System.Collections.Generic.IList<string>? matchHosts,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesProxyHeader>? requestHeaders)
        {
            this.AttributionHeaders = attributionHeaders;
            this.FullRequest = fullRequest;
            this.MatchHosts = matchHosts;
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