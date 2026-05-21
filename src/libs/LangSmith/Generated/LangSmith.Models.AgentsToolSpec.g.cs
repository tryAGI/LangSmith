
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AgentsToolSpec
    {
        /// <summary>
        /// Display name for the tool. Defaults to the tool name when empty.<br/>
        /// Example: read_url_content
        /// </summary>
        /// <example>read_url_content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Display name for the MCP server. Defaults to the URL when empty.<br/>
        /// Example: Fleet
        /// </summary>
        /// <example>Fleet</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_name")]
        public string? McpServerName { get; set; }

        /// <summary>
        /// URL of the MCP server hosting this tool.<br/>
        /// Example: https://tools.example.com
        /// </summary>
        /// <example>https://tools.example.com</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_server_url")]
        public string? McpServerUrl { get; set; }

        /// <summary>
        /// Tool name as exposed by the MCP server.<br/>
        /// Example: read_url_content
        /// </summary>
        /// <example>read_url_content</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsToolSpec" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name for the tool. Defaults to the tool name when empty.<br/>
        /// Example: read_url_content
        /// </param>
        /// <param name="mcpServerName">
        /// Display name for the MCP server. Defaults to the URL when empty.<br/>
        /// Example: Fleet
        /// </param>
        /// <param name="mcpServerUrl">
        /// URL of the MCP server hosting this tool.<br/>
        /// Example: https://tools.example.com
        /// </param>
        /// <param name="name">
        /// Tool name as exposed by the MCP server.<br/>
        /// Example: read_url_content
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentsToolSpec(
            string? displayName,
            string? mcpServerName,
            string? mcpServerUrl,
            string? name)
        {
            this.DisplayName = displayName;
            this.McpServerName = mcpServerName;
            this.McpServerUrl = mcpServerUrl;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentsToolSpec" /> class.
        /// </summary>
        public AgentsToolSpec()
        {
        }

    }
}