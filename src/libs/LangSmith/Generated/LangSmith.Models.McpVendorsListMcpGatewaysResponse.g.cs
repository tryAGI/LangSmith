
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsListMcpGatewaysResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_count")]
        public int? PageCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsListMcpGatewaysResponse" /> class.
        /// </summary>
        /// <param name="items"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="pageCount"></param>
        /// <param name="totalCount"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsListMcpGatewaysResponse(
            global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpGateway>? items,
            int? limit,
            int? offset,
            int? pageCount,
            int? totalCount)
        {
            this.Items = items;
            this.Limit = limit;
            this.Offset = offset;
            this.PageCount = pageCount;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsListMcpGatewaysResponse" /> class.
        /// </summary>
        public McpVendorsListMcpGatewaysResponse()
        {
        }
    }
}