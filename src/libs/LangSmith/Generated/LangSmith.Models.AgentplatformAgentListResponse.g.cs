
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AgentplatformAgentListResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgent> Items { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Total visible Agents matching the filters, independently of the cursor.<br/>
        /// Omitted unless include_count is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentListResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="nextCursor"></param>
        /// <param name="totalCount">
        /// Total visible Agents matching the filters, independently of the cursor.<br/>
        /// Omitted unless include_count is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentplatformAgentListResponse(
            global::System.Collections.Generic.IList<global::LangSmith.AgentplatformAgent> items,
            string? nextCursor,
            int? totalCount)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextCursor = nextCursor;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentplatformAgentListResponse" /> class.
        /// </summary>
        public AgentplatformAgentListResponse()
        {
        }

    }
}