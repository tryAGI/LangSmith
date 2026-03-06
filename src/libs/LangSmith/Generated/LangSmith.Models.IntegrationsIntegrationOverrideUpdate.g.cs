
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsIntegrationOverrideUpdate
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_key")]
        public string? IntegrationKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegrationOverrideUpdate" /> class.
        /// </summary>
        /// <param name="integrationKey"></param>
        /// <param name="isEnabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsIntegrationOverrideUpdate(
            string? integrationKey,
            bool? isEnabled)
        {
            this.IntegrationKey = integrationKey;
            this.IsEnabled = isEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsIntegrationOverrideUpdate" /> class.
        /// </summary>
        public IntegrationsIntegrationOverrideUpdate()
        {
        }
    }
}