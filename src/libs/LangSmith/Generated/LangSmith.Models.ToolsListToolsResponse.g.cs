
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolsListToolsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_offset")]
        public int? NextOffset { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tools")]
        public global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? Tools { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsListToolsResponse" /> class.
        /// </summary>
        /// <param name="nextOffset"></param>
        /// <param name="tools"></param>
        /// <param name="total"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsListToolsResponse(
            int? nextOffset,
            global::System.Collections.Generic.IList<global::LangSmith.ToolsTool>? tools,
            int? total)
        {
            this.NextOffset = nextOffset;
            this.Tools = tools;
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsListToolsResponse" /> class.
        /// </summary>
        public ToolsListToolsResponse()
        {
        }
    }
}