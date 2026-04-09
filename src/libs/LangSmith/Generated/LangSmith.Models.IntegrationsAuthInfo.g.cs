
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsAuthInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_id")]
        public string? AuthProviderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("auth_provider_type")]
        public string? AuthProviderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAuthInfo" /> class.
        /// </summary>
        /// <param name="authProviderId"></param>
        /// <param name="authProviderType"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsAuthInfo(
            string? authProviderId,
            string? authProviderType,
            string? type)
        {
            this.AuthProviderId = authProviderId;
            this.AuthProviderType = authProviderType;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAuthInfo" /> class.
        /// </summary>
        public IntegrationsAuthInfo()
        {
        }
    }
}