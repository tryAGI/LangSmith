#nullable enable

namespace LangSmith
{
    public partial interface IFleetIntegrationsClient
    {
        /// <summary>
        /// Delete a custom integration<br/>
        /// Idempotent. Returns 204 whether or not the integration existed.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteACustomIntegrationAsync(
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}