#nullable enable

namespace LangSmith
{
    public partial interface IIntegrationsClient
    {
        /// <summary>
        /// Get Agent Builder integrations settings<br/>
        /// Returns default policy, integration overrides, and known integrations for the current workspace.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsAgentBuilderIntegrationsPayload> GetAgentBuilderIntegrationsSettingsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}