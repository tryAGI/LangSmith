#nullable enable

namespace LangSmith
{
    public partial interface IOwnershipsClient
    {
        /// <summary>
        /// List Repo Owners<br/>
        /// List all owners of a repo.<br/>
        /// Requires read permission on the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRepoOwnersResponse> ListRepoOwnersAsync(
            string owner,
            string repo,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}