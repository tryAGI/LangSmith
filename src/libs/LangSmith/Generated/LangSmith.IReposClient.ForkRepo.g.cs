#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Fork Repo<br/>
        /// Fork a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRepoResponse> ForkRepoAsync(
            string owner,
            string repo,
            global::LangSmith.ForkRepoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Fork Repo<br/>
        /// Fork a repo.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="repoHandle"></param>
        /// <param name="readme"></param>
        /// <param name="description"></param>
        /// <param name="tags"></param>
        /// <param name="isPublic"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRepoResponse> ForkRepoAsync(
            string owner,
            string repo,
            string repoHandle,
            global::LangSmith.AnyOf<string, object>? readme = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::LangSmith.AnyOf<bool?, object>? isPublic = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}