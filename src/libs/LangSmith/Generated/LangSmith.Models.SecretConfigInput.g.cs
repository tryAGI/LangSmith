
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A host a workspace secret may be sent to, and how it is sent.
    /// </summary>
    public sealed partial class SecretConfigInput
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretConfigInput" /> class.
        /// </summary>
        /// <param name="hostPattern">
        /// Exact host or a leading '*.' wildcard, e.g. 'api.openai.com'.
        /// </param>
        /// <param name="headerName">
        /// HTTP header the secret is sent in. Null leaves it to the consumer.
        /// </param>
        /// <param name="headerValueTemplate">
        /// Header value with '{value}' replaced by the secret, e.g. 'Bearer {value}'. Null sends the raw secret.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SecretConfigInput(
            string hostPattern,
            string? headerName,
            string? headerValueTemplate)
        {
            this.HostPattern = hostPattern ?? throw new global::System.ArgumentNullException(nameof(hostPattern));
            this.HeaderName = headerName;
            this.HeaderValueTemplate = headerValueTemplate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SecretConfigInput" /> class.
        /// </summary>
        public SecretConfigInput()
        {
        }

    }
}