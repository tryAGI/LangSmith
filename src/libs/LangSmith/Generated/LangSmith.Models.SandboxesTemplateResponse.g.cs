
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SandboxesTemplateResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated: template-level proxy config is legacy; configure proxy rules per box instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_config")]
        public global::LangSmith.SandboxesProxyConfig? ProxyConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_id")]
        public string? RegistryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("registry_name")]
        public string? RegistryName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        public global::LangSmith.SandboxesResourceSpec? Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("volume_mounts")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountSpec>? VolumeMounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesTemplateResponse" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="image"></param>
        /// <param name="name"></param>
        /// <param name="proxyConfig">
        /// Deprecated: template-level proxy config is legacy; configure proxy rules per box instead.
        /// </param>
        /// <param name="registryId"></param>
        /// <param name="registryName"></param>
        /// <param name="resources"></param>
        /// <param name="updatedAt"></param>
        /// <param name="volumeMounts"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesTemplateResponse(
            string? createdAt,
            string? id,
            string? image,
            string? name,
            global::LangSmith.SandboxesProxyConfig? proxyConfig,
            string? registryId,
            string? registryName,
            global::LangSmith.SandboxesResourceSpec? resources,
            string? updatedAt,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesVolumeMountSpec>? volumeMounts)
        {
            this.CreatedAt = createdAt;
            this.Id = id;
            this.Image = image;
            this.Name = name;
            this.ProxyConfig = proxyConfig;
            this.RegistryId = registryId;
            this.RegistryName = registryName;
            this.Resources = resources;
            this.UpdatedAt = updatedAt;
            this.VolumeMounts = volumeMounts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesTemplateResponse" /> class.
        /// </summary>
        public SandboxesTemplateResponse()
        {
        }
    }
}