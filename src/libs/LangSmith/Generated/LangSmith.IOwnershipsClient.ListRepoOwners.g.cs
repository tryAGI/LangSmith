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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ListRepoOwnersResponse> ListRepoOwnersAsync(
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}