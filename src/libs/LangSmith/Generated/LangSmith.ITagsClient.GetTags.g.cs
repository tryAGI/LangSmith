#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Get Tags
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="owner1"></param>
        /// <param name="owner2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.RepoTag>> GetTagsAsync(
            string repo,
            string owner1,
            string owner2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}