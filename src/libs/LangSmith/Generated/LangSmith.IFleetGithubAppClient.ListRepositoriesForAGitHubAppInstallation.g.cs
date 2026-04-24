#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// List repositories for a GitHub App installation<br/>
        /// Return repositories accessible to the specified GitHub App installation.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.GithubAppRepository>> ListRepositoriesForAGitHubAppInstallationAsync(
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}