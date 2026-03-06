
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IntegrationsAgentBuilderIntegrationsUpdatePayload
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("integration_overrides")]
        public global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? IntegrationOverrides { get; set; }

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
        /// Initializes a new instance of the <see cref="IntegrationsAgentBuilderIntegrationsUpdatePayload" /> class.
        /// </summary>
        /// <param name="integrationOverrides"></param>
        /// <param name="integrationsEnabledByDefault"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IntegrationsAgentBuilderIntegrationsUpdatePayload(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? integrationOverrides,
            bool? integrationsEnabledByDefault)
        {
            this.IntegrationOverrides = integrationOverrides;
            this.IntegrationsEnabledByDefault = integrationsEnabledByDefault;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsAgentBuilderIntegrationsUpdatePayload" /> class.
        /// </summary>
        public IntegrationsAgentBuilderIntegrationsUpdatePayload()
        {
        }
    }
}