
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpVendorsGetMcpVendorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("connected_accounts")]
        public global::System.Collections.Generic.IList<global::LangSmith.McpVendorsOAuthTokenSummary>? ConnectedAccounts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("icon")]
        public string? Icon { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.McpVendorsMcpVendorStatusJsonConverter))]
        public global::LangSmith.McpVendorsMcpVendorStatus? Status { get; set; }

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
        /// Initializes a new instance of the <see cref="McpVendorsGetMcpVendorResponse" /> class.
        /// </summary>
        /// <param name="connectedAccounts"></param>
        /// <param name="description"></param>
        /// <param name="icon"></param>
        /// <param name="name"></param>
        /// <param name="providerId"></param>
        /// <param name="status"></param>
        /// <param name="vendorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpVendorsGetMcpVendorResponse(
            global::System.Collections.Generic.IList<global::LangSmith.McpVendorsOAuthTokenSummary>? connectedAccounts,
            string? description,
            string? icon,
            string? name,
            string? providerId,
            global::LangSmith.McpVendorsMcpVendorStatus? status,
            string? vendorId)
        {
            this.ConnectedAccounts = connectedAccounts;
            this.Description = description;
            this.Icon = icon;
            this.Name = name;
            this.ProviderId = providerId;
            this.Status = status;
            this.VendorId = vendorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpVendorsGetMcpVendorResponse" /> class.
        /// </summary>
        public McpVendorsGetMcpVendorResponse()
        {
        }
    }
}