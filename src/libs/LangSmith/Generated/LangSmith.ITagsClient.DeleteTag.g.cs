#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Delete Tag<br/>
        /// Delete a tag. Requires repo ownership, prompts:tag permission, or ABAC grant.
        /// </summary>
        /// <param name="owner1"></param>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagAsync(
            string owner1,
            string repo,
            string tagName,
            string owner2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}