#nullable enable

namespace LangSmith
{
    public partial interface IHubEnvironmentsClient
    {
        /// <summary>
        /// Delete hub environments model<br/>
        /// Deletes the hub environments configuration. Tenant reverts to defaults.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> DeleteHubEnvironmentsModelAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}