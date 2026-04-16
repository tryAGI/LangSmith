
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangchainComSmithFleetMcpServersUpdateMcpServerPayload
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
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.IList<object>? Headers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oauth_provider_id")]
        public string? OauthProviderId { get; set; }

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
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersUpdateMcpServerPayload" /> class.
        /// </summary>
        /// <param name="authType"></param>
        /// <param name="headers"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="url"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangchainComSmithFleetMcpServersUpdateMcpServerPayload(
            global::LangSmith.LangchainComSmithFleetMcpServersAuthType? authType,
            global::System.Collections.Generic.IList<object>? headers,
            string? oauthProviderId,
            string? url)
        {
            this.AuthType = authType;
            this.Headers = headers;
            this.OauthProviderId = oauthProviderId;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersUpdateMcpServerPayload" /> class.
        /// </summary>
        public LangchainComSmithFleetMcpServersUpdateMcpServerPayload()
        {
        }
    }
}