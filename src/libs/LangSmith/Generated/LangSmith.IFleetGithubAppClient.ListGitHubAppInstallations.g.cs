#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// List GitHub App installations<br/>
        /// Return GitHub App installations linked to the current user from<br/>
        /// our database. This is a cache — it does not hit the GitHub API.<br/>
        /// Use POST /installations/refresh to force a fresh sync from GitHub.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GithubAppInstallation>> ListGitHubAppInstallationsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}