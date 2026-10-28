
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class McpToolsResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Tools { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Cached { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fetched_at")]
        public global::System.DateTime? FetchedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("server_icon_url")]
        public string? ServerIconUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsResponse" /> class.
        /// </summary>
        /// <param name="tools"></param>
        /// <param name="cached"></param>
        /// <param name="fetchedAt"></param>
        /// <param name="serverIconUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpToolsResponse(
            global::System.Collections.Generic.IList<object> tools,
            bool cached,
            global::System.DateTime? fetchedAt,
            string? serverIconUrl)
        {
            this.Tools = tools ?? throw new global::System.ArgumentNullException(nameof(tools));
            this.Cached = cached;
            this.FetchedAt = fetchedAt;
            this.ServerIconUrl = serverIconUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpToolsResponse" /> class.
        /// </summary>
        public McpToolsResponse()
        {
        }

    }
}