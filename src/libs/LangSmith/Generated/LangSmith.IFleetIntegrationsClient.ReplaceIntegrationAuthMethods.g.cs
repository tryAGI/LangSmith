#nullable enable

namespace LangSmith
{
    public partial interface IFleetIntegrationsClient
    {
        /// <summary>
        /// Replace integration auth methods<br/>
        /// Replaces the integration's full list of supported auth methods.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> ReplaceIntegrationAuthMethodsAsync(
            string id,

            global::LangSmith.IntegrationsReplaceAuthMethodsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Replace integration auth methods<br/>
        /// Replaces the integration's full list of supported auth methods.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="authMethods"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> ReplaceIntegrationAuthMethodsAsync(
            string id,
            global::System.Collections.Generic.IList<global::LangSmith.IntegrationsAuthMethod>? authMethods = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}