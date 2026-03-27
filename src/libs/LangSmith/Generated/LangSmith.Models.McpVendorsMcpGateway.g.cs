
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsMcpGateway
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        public string? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("binding")]
        public global::LangSmith.McpVendorsMcpGatewayBinding? Binding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("slug")]
        public string? Slug { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_filter")]
        public global::LangSmith.McpVendorsMcpGatewayToolFilter? ToolFilter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsMcpGateway" /> class.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="binding"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="id"></param>
        /// <param name="instructions"></param>
        /// <param name="name"></param>
        /// <param name="slug"></param>
        /// <param name="status"></param>
        /// <param name="toolFilter"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsMcpGateway(
            string? authType,
            global::LangSmith.McpVendorsMcpGatewayBinding? binding,
            string? createdAt,
            string? description,
            string? id,
            string? instructions,
            string? name,
            string? slug,
            string? status,
            global::LangSmith.McpVendorsMcpGatewayToolFilter? toolFilter,
            string? updatedAt)
        {
            this.AuthType = authType;
            this.Binding = binding;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Id = id;
            this.Instructions = instructions;
            this.Name = name;
            this.Slug = slug;
            this.Status = status;
            this.ToolFilter = toolFilter;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsMcpGateway" /> class.
        /// </summary>
        public McpVendorsMcpGateway()
        {
        }
    }
}