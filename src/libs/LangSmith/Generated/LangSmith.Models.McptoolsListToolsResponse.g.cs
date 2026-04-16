
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McptoolsListToolsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached")]
        public bool? Cached { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fetched_at")]
        public string? FetchedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::LangSmith.McptoolsTool>? Tools { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McptoolsListToolsResponse" /> class.
        /// </summary>
        /// <param name="cached"></param>
        /// <param name="fetchedAt"></param>
        /// <param name="tools"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McptoolsListToolsResponse(
            bool? cached,
            string? fetchedAt,
            global::System.Collections.Generic.IList<global::LangSmith.McptoolsTool>? tools)
        {
            this.Cached = cached;
            this.FetchedAt = fetchedAt;
            this.Tools = tools;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McptoolsListToolsResponse" /> class.
        /// </summary>
        public McptoolsListToolsResponse()
        {
        }
    }
}