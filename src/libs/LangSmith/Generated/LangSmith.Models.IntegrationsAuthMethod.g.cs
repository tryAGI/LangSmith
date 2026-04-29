
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsAuthMethod
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_match")]
        public global::LangSmith.IntegrationsProviderMatch? ProviderMatch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.IntegrationsAuthTypeJsonConverter))]
        public global::LangSmith.IntegrationsAuthType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAuthMethod" /> class.
        /// </summary>
        /// <param name="providerMatch"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsAuthMethod(
            global::LangSmith.IntegrationsProviderMatch? providerMatch,
            global::LangSmith.IntegrationsAuthType? type)
        {
            this.ProviderMatch = providerMatch;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAuthMethod" /> class.
        /// </summary>
        public IntegrationsAuthMethod()
        {
        }
    }
}