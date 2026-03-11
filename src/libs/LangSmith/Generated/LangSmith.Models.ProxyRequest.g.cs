
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProxyRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Default Value: GET
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("method")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ProxyRequestMethodJsonConverter))]
        public global::LangSmith.ProxyRequestMethod? Method { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        /// Default Value: 120
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout")]
        public int? Timeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("body")]
        public object? Body { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_provider_id")]
        public string? OauthProviderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyRequest" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="method">
        /// Default Value: GET
        /// </param>
        /// <param name="headers"></param>
        /// <param name="timeout">
        /// Default Value: 120
        /// </param>
        /// <param name="body"></param>
        /// <param name="oauthProviderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProxyRequest(
            string url,
            global::LangSmith.ProxyRequestMethod? method,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            int? timeout,
            object? body,
            string? oauthProviderId)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Method = method;
            this.Headers = headers;
            this.Timeout = timeout;
            this.Body = body;
            this.OauthProviderId = oauthProviderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProxyRequest" /> class.
        /// </summary>
        public ProxyRequest()
        {
        }
    }
}