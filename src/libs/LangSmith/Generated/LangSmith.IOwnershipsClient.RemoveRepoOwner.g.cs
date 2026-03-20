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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveRepoOwnerAsync(
            string owner,
            string repo,

            global::LangSmith.RemoveRepoOwnerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Remove Repo Owner<br/>
        /// Remove an owner from a repo.<br/>
        /// Requires being an existing owner of the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> RemoveRepoOwnerAsync(
            string owner,
            string repo,
            global::System.Guid identityId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}