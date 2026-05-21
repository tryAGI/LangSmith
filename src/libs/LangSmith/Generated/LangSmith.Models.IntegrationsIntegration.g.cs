
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
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_methods")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthMethod>? AuthMethods { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("category")]
        public string? Category { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("transport")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IntegrationsTransportJsonConverter))]
        public global::LangSmith.IntegrationsTransport? Transport { get; set; }

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
        /// <param name="authMethods"></param>
        /// <param name="category"></param>
        /// <param name="createdAt"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="iconUrl"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="transport"></param>
        /// <param name="updatedAt"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsIntegration(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthMethod>? authMethods,
            string? category,
            string? createdAt,
            string? description,
            bool? enabled,
            string? iconUrl,
            string? id,
            string? name,
            string? source,
            global::LangSmith.IntegrationsTransport? transport,
            string? updatedAt,
            string? url)
        {
            this.AuthMethods = authMethods;
            this.Category = category;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.Enabled = enabled;
            this.IconUrl = iconUrl;
            this.Id = id;
            this.Name = name;
            this.Source = source;
            this.Transport = transport;
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