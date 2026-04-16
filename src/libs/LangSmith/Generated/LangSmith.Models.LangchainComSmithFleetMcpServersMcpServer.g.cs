
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangchainComSmithFleetMcpServersMcpServer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.LangchainComSmithFleetMcpServersAuthTypeJsonConverter))]
        public global::LangSmith.LangchainComSmithFleetMcpServersAuthType? AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_invoke")]
        public bool? CanInvoke { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_system_id")]
        public string? ExternalSystemId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<object>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mcp_vendor_id")]
        public string? McpVendorId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.LangchainComSmithFleetMcpServersOAuthModeJsonConverter))]
        public global::LangSmith.LangchainComSmithFleetMcpServersOAuthMode? OauthMode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_provider_id")]
        public string? OauthProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_list_cache")]
        public object? ToolListCache { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_list_cache_expires_at")]
        public string? ToolListCacheExpiresAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vendor_id")]
        public string? VendorId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersMcpServer" /> class.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="canInvoke"></param>
        /// <param name="createdAt"></param>
        /// <param name="externalSystemId"></param>
        /// <param name="headers"></param>
        /// <param name="id"></param>
        /// <param name="mcpVendorId"></param>
        /// <param name="name"></param>
        /// <param name="oauthMode"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="tenantId"></param>
        /// <param name="toolListCache"></param>
        /// <param name="toolListCacheExpiresAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
        /// <param name="vendorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangchainComSmithFleetMcpServersMcpServer(
            global::LangSmith.LangchainComSmithFleetMcpServersAuthType? authType,
            bool? canInvoke,
            string? createdAt,
            string? externalSystemId,
            global::System.Collections.Generic.IList<object>? headers,
            string? id,
            string? mcpVendorId,
            string? name,
            global::LangSmith.LangchainComSmithFleetMcpServersOAuthMode? oauthMode,
            string? oauthProviderId,
            string? tenantId,
            object? toolListCache,
            string? toolListCacheExpiresAt,
            string? updatedAt,
            string? url,
            string? vendorId)
        {
            this.AuthType = authType;
            this.CanInvoke = canInvoke;
            this.CreatedAt = createdAt;
            this.ExternalSystemId = externalSystemId;
            this.Headers = headers;
            this.Id = id;
            this.McpVendorId = mcpVendorId;
            this.Name = name;
            this.OauthMode = oauthMode;
            this.OauthProviderId = oauthProviderId;
            this.TenantId = tenantId;
            this.ToolListCache = toolListCache;
            this.ToolListCacheExpiresAt = toolListCacheExpiresAt;
            this.UpdatedAt = updatedAt;
            this.Url = url;
            this.VendorId = vendorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersMcpServer" /> class.
        /// </summary>
        public LangchainComSmithFleetMcpServersMcpServer()
        {
        }
    }
}