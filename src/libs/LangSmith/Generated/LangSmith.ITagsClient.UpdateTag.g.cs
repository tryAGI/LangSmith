#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Update Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> UpdateTagAsync(
            string repo,
            string tagName,
            string owner,
            global::LangSmith.RepoUpdateTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="commitId"></param>
        /// <param name="skipWebhooks">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> UpdateTagAsync(
            string repo,
            string tagName,
            string owner,
            global::System.Guid commitId,
            global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? skipWebhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}