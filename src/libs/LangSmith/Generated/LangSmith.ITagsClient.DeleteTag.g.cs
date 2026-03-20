#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {

        /// <summary>
        /// Delete Tag<br/>
        /// Delete a tag. Requires repo ownership, prompts:tag permission, or ABAC grant.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteTagAsync(
            string owner,
            string repo,
            string tagName,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}