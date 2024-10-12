#nullable enable

namespace LangSmith
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// Create Commit<br/>
        /// Upload a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRepoCommitResponse> CreateCommitAsync(
            string owner,
            string repo,
            global::LangSmith.CreateRepoCommitRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Commit<br/>
        /// Upload a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="manifest"></param>
        /// <param name="parentCommit"></param>
        /// <param name="exampleRunIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateRepoCommitResponse> CreateCommitAsync(
            string owner,
            string repo,
            object manifest,
            string? parentCommit = default,
            global::System.Collections.Generic.IList<global::System.Guid>? exampleRunIds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}