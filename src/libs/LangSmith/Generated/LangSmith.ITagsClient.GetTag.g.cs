#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Get Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> GetTagAsync(
            string repo,
            string tagName,
            string owner,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}