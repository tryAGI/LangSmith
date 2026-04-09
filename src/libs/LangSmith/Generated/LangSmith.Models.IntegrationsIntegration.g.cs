
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsIntegration
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthInfo>? Auth { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("icon_url")]
        public string? IconUrl { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("required_scopes")]
        public global::System.Collections.Generic.IList<string>? RequiredScopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IntegrationsIntegrationTypeJsonConverter))]
        public global::LangSmith.IntegrationsIntegrationType? Type { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegration" /> class.
        /// </summary>
        /// <param name="auth"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="iconUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="requiredScopes"></param>
        /// <param name="type"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsIntegration(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthInfo>? auth,
            string? createdAt,
            string? description,
            string? iconUrl,
            string? id,
            string? name,
            global::System.Collections.Generic.IList<string>? requiredScopes,
            global::LangSmith.IntegrationsIntegrationType? type,
            string? updatedAt,
            string? url)
        {
            this.Auth = auth;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.Name = name;
            this.RequiredScopes = requiredScopes;
            this.Type = type;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegration" /> class.
        /// </summary>
        public IntegrationsIntegration()
        {
        }
    }
}