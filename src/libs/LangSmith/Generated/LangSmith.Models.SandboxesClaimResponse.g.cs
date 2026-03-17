
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesClaimResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataplane_url")]
        public string? DataplaneUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_message")]
        public string? StatusMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("template_name")]
        public string? TemplateName { get; set; }

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
        /// Initializes a new instance of the <see cref="SandboxesClaimResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="dataplaneUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig"></param>
        /// <param name="status"></param>
        /// <param name="statusMessage"></param>
        /// <param name="templateName"></param>
        /// <param name="updatedAt"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesClaimResponse(
            string? createdAt,
            string? dataplaneUrl,
            string? id,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            string? status,
            string? statusMessage,
            string? templateName,
            string? updatedAt)
        {
            this.CreatedAt = createdAt;
            this.DataplaneUrl = dataplaneUrl;
            this.Id = id;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.Status = status;
            this.StatusMessage = statusMessage;
            this.TemplateName = templateName;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesClaimResponse" /> class.
        /// </summary>
        public SandboxesClaimResponse()
        {
        }
    }
}