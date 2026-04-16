
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangchainComSmithFleetMcpServersCreateMcpServerPayload
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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

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
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersCreateMcpServerPayload" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="url"></param>
        /// <param name="authType"></param>
        /// <param name="externalSystemId"></param>
        /// <param name="headers"></param>
        /// <param name="oauthMode"></param>
        /// <param name="oauthProviderId"></param>
        /// <param name="vendorId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangchainComSmithFleetMcpServersCreateMcpServerPayload(
            string name,
            string url,
            global::LangSmith.LangchainComSmithFleetMcpServersAuthType? authType,
            string? externalSystemId,
            global::System.Collections.Generic.IList<object>? headers,
            global::LangSmith.LangchainComSmithFleetMcpServersOAuthMode? oauthMode,
            string? oauthProviderId,
            string? vendorId)
        {
            this.AuthType = authType;
            this.ExternalSystemId = externalSystemId;
            this.Headers = headers;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.OauthMode = oauthMode;
            this.OauthProviderId = oauthProviderId;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.VendorId = vendorId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersCreateMcpServerPayload" /> class.
        /// </summary>
        public LangchainComSmithFleetMcpServersCreateMcpServerPayload()
        {
        }
    }
}