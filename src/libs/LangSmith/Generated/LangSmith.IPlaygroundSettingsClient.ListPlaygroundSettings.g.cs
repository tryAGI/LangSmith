#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// List Playground Settings<br/>
        /// Get all playground settings for this tenant id.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PlaygroundSettingsResponse>> ListPlaygroundSettingsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}