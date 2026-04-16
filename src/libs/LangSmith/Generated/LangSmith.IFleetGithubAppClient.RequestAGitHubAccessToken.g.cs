#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// Request a GitHub access token<br/>
        /// Return a short-lived GitHub access token scoped to the given repository.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GithubAppUserTokenResponse> RequestAGitHubAccessTokenAsync(

            global::LangSmith.GithubAppTokenRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request a GitHub access token<br/>
        /// Return a short-lived GitHub access token scoped to the given repository.
        /// </summary>
        /// <param name="repository"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GithubAppUserTokenResponse> RequestAGitHubAccessTokenAsync(
            string? repository = default,
            string? type = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}