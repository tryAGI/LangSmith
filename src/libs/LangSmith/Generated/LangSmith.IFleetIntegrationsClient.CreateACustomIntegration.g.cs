#nullable enable

namespace LangSmith
{
    public partial interface IFleetIntegrationsClient
    {
        /// <summary>
        /// Create a custom integration<br/>
        /// Registers a new custom integration. Type is forced to CUSTOM.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> CreateACustomIntegrationAsync(

            global::LangSmith.IntegrationsCreateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a custom integration<br/>
        /// Registers a new custom integration. Type is forced to CUSTOM.
        /// </summary>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="iconUrl"></param>
        /// <param name="name"></param>
        /// <param name="source"></param>
        /// <param name="url"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> CreateACustomIntegrationAsync(
            string name,
            string url,
            string? category = default,
            string? description = default,
            string? iconUrl = default,
            string? source = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}