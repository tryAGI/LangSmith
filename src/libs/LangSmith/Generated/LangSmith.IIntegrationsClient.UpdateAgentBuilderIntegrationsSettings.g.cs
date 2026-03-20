#nullable enable

namespace LangSmith
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Update Agent Builder integrations settings<br/>
        /// Replaces default policy and integration overrides for the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload> UpdateAgentBuilderIntegrationsSettingsAsync(

            global::LangSmith.IntegrationsAgentBuilderIntegrationsUpdatePayload request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Agent Builder integrations settings<br/>
        /// Replaces default policy and integration overrides for the current workspace.
        /// </summary>
        /// <param name="integrationOverrides"></param>
        /// <param name="integrationsEnabledByDefault"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload> UpdateAgentBuilderIntegrationsSettingsAsync(
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsIntegrationOverrideUpdate>? integrationOverrides = default,
            bool? integrationsEnabledByDefault = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}