
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse
    {
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
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse" /> class.
        /// </summary>
        /// <param name="oauthProviderId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse(
            string? oauthProviderId)
        {
            this.OauthProviderId = oauthProviderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse" /> class.
        /// </summary>
        public LangchainComSmithFleetMcpServersRegisterOAuthProviderResponse()
        {
        }
    }
}