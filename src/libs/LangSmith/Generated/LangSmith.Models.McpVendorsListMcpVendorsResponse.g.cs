
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsListMcpVendorsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_vendors")]
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? McpVendors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsListMcpVendorsResponse" /> class.
        /// </summary>
        /// <param name="mcpVendors"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsListMcpVendorsResponse(
            global::System.Collections.Generic.IList<global::LangSmith.McpVendorsMcpVendor>? mcpVendors)
        {
            this.McpVendors = mcpVendors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsListMcpVendorsResponse" /> class.
        /// </summary>
        public McpVendorsListMcpVendorsResponse()
        {
        }
    }
}