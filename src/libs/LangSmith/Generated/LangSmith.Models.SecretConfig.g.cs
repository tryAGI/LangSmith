
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SecretConfig
    {
        /// <summary>
        /// Exact host or a leading '*.' wildcard, e.g. 'api.openai.com'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("host_pattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HostPattern { get; set; }

        /// <summary>
        /// HTTP header the secret is sent in. Null leaves it to the consumer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_name")]
        public string? HeaderName { get; set; }

        /// <summary>
        /// Header value with '{value}' replaced by the secret, e.g. 'Bearer {value}'. Null sends the raw secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("header_value_template")]
        public string? HeaderValueTemplate { get; set; }

        /// <summary>
        /// Omitted for a built-in default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Whether a secret config comes from the built-in catalog or an admin.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SecretConfigSourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.SecretConfigSource Source { get; set; }

        /// <summary>
        /// Omitted for a built-in default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Omitted for a built-in default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretConfig" /> class.
        /// </summary>
        /// <param name="hostPattern">
        /// Exact host or a leading '*.' wildcard, e.g. 'api.openai.com'.
        /// </param>
        /// <param name="source">
        /// Whether a secret config comes from the built-in catalog or an admin.
        /// </param>
        /// <param name="headerName">
        /// HTTP header the secret is sent in. Null leaves it to the consumer.
        /// </param>
        /// <param name="headerValueTemplate">
        /// Header value with '{value}' replaced by the secret, e.g. 'Bearer {value}'. Null sends the raw secret.
        /// </param>
        /// <param name="id">
        /// Omitted for a built-in default.
        /// </param>
        /// <param name="createdAt">
        /// Omitted for a built-in default.
        /// </param>
        /// <param name="updatedAt">
        /// Omitted for a built-in default.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretConfig(
            string hostPattern,
            global::LangSmith.SecretConfigSource source,
            string? headerName,
            string? headerValueTemplate,
            global::System.Guid? id,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.HostPattern = hostPattern ?? throw new global::System.ArgumentNullException(nameof(hostPattern));
            this.HeaderName = headerName;
            this.HeaderValueTemplate = headerValueTemplate;
            this.Id = id;
            this.Source = source;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretConfig" /> class.
        /// </summary>
        public SecretConfig()
        {
        }

    }
}