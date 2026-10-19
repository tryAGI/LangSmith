
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesCreateBrowserWindowLinksPayload
    {
        /// <summary>
        /// EmbedOrigins are the origins whose pages may show the window's pages in<br/>
        /// an iframe, such as https://app.example.com: https, or http on<br/>
        /// localhost, with no path. Without them no page may frame the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed_origins")]
        public global::System.Collections.Generic.IList<string>? EmbedOrigins { get; set; }

        /// <summary>
        /// TTLSeconds is how long the links work, from 60 seconds to 24 hours.<br/>
        /// Defaults to 24 hours.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl_seconds")]
        public int? TtlSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateBrowserWindowLinksPayload" /> class.
        /// </summary>
        /// <param name="embedOrigins">
        /// EmbedOrigins are the origins whose pages may show the window's pages in<br/>
        /// an iframe, such as https://app.example.com: https, or http on<br/>
        /// localhost, with no path. Without them no page may frame the window.
        /// </param>
        /// <param name="ttlSeconds">
        /// TTLSeconds is how long the links work, from 60 seconds to 24 hours.<br/>
        /// Defaults to 24 hours.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesCreateBrowserWindowLinksPayload(
            global::System.Collections.Generic.IList<string>? embedOrigins,
            int? ttlSeconds)
        {
            this.EmbedOrigins = embedOrigins;
            this.TtlSeconds = ttlSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesCreateBrowserWindowLinksPayload" /> class.
        /// </summary>
        public SandboxesCreateBrowserWindowLinksPayload()
        {
        }

    }
}