#nullable enable

namespace LangSmith
{
    public partial interface IFleetIntegrationsClient
    {
        /// <summary>
        /// Update a custom integration<br/>
        /// Updates mutable fields. URL is immutable.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> UpdateACustomIntegrationAsync(
            string id,

            global::LangSmith.IntegrationsUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a custom integration<br/>
        /// Updates mutable fields. URL is immutable.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <param name="description"></param>
        /// <param name="enabled"></param>
        /// <param name="iconUrl"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsIntegration> UpdateACustomIntegrationAsync(
            string id,
            string? category = default,
            string? description = default,
            bool? enabled = default,
            string? iconUrl = default,
            string? name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}