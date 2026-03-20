#nullable enable

namespace LangSmith
{
    public partial interface IOwnershipsClient
    {
        /// <summary>
        /// Add Repo Owner<br/>
        /// Add an owner to a repo.<br/>
        /// Requires being an existing owner of the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoOwner> AddRepoOwnerAsync(
            string owner,
            string repo,

            global::LangSmith.AddRepoOwnerRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Repo Owner<br/>
        /// Add an owner to a repo.<br/>
        /// Requires being an existing owner of the repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoOwner> AddRepoOwnerAsync(
            string owner,
            string repo,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}