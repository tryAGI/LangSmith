#nullable enable

namespace LangSmith
{
    public partial interface IPlaygroundSettingsClient
    {
        /// <summary>
        /// Get Playground Settings<br/>
        /// Get a single playground settings by ID.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> GetPlaygroundSettingsAsync(
            string playgroundSettingsId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}