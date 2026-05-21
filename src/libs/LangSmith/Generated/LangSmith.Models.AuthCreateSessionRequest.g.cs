
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthCreateSessionRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_id")]
        public string? AgentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_id")]
        public string? ProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.AuthSessionStrategyJsonConverter))]
        public global::LangSmith.AuthSessionStrategy? Strategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("token_id")]
        public string? TokenId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCreateSessionRequest" /> class.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="isDefault"></param>
        /// <param name="providerId"></param>
        /// <param name="scopes"></param>
        /// <param name="strategy"></param>
        /// <param name="tokenId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthCreateSessionRequest(
            string? agentId,
            bool? isDefault,
            string? providerId,
            global::System.Collections.Generic.IList<string>? scopes,
            global::LangSmith.AuthSessionStrategy? strategy,
            string? tokenId)
        {
            this.AgentId = agentId;
            this.IsDefault = isDefault;
            this.ProviderId = providerId;
            this.Scopes = scopes;
            this.Strategy = strategy;
            this.TokenId = tokenId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthCreateSessionRequest" /> class.
        /// </summary>
        public AuthCreateSessionRequest()
        {
        }

    }
}