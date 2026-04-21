#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// Refresh GitHub App installations<br/>
        /// Trigger a live sync with GitHub for the current user's GitHub App<br/>
        /// installations. Upserts new installations, deletes stale ones, and<br/>
        /// returns the refreshed list. Requires an existing GitHub connection.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GithubAppInstallation>> RefreshGitHubAppInstallationsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}