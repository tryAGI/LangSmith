#nullable enable

namespace LangSmith
{
    public partial interface IOwnershipsClient
    {
        /// <summary>
        /// Remove Repo Owner<br/>
        /// Remove an owner from a repo.<br/>
        /// Requires being an existing owner of the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveRepoOwnerAsync(
            string owner,
            string repo,

            global::LangSmith.RemoveRepoOwnerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Repo Owner<br/>
        /// Remove an owner from a repo.<br/>
        /// Requires being an existing owner of the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="identityId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveRepoOwnerAsync(
            string owner,
            string repo,
            global::System.Guid identityId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}