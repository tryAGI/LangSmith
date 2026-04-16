#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// Get GitHub user connection status<br/>
        /// Return the current user's GitHub connection status and metadata.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GithubAppUserConnectionStatus> GetGitHubUserConnectionStatusAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}