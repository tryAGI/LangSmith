
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsAgentBuilderIntegrationsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_catalog")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? IntegrationCatalog { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_overrides")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? IntegrationOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integrations_enabled_by_default")]
        public bool? IntegrationsEnabledByDefault { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAgentBuilderIntegrationsPayload" /> class.
        /// </summary>
        /// <param name="integrationCatalog"></param>
        /// <param name="integrationOverrides"></param>
        /// <param name="integrationsEnabledByDefault"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsAgentBuilderIntegrationsPayload(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationCatalogEntry>? integrationCatalog,
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverride>? integrationOverrides,
            bool? integrationsEnabledByDefault)
        {
            this.IntegrationCatalog = integrationCatalog;
            this.IntegrationOverrides = integrationOverrides;
            this.IntegrationsEnabledByDefault = integrationsEnabledByDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAgentBuilderIntegrationsPayload" /> class.
        /// </summary>
        public IntegrationsAgentBuilderIntegrationsPayload()
        {
        }
    }
}