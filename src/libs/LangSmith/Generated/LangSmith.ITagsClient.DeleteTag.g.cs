#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Delete Tag
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagAsync(
            string repo,
            string tagName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}