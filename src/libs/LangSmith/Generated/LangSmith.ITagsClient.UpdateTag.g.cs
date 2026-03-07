#nullable enable

namespace LangSmith
{
    public partial interface ITagsClient
    {
        /// <summary>
        /// Update Tag<br/>
        /// Update a tag. Requires repo ownership, prompts:tag permission, or ABAC grant.
        /// </summary>
        /// <param name="owner1"></param>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner2"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> UpdateTagAsync(
            string owner1,
            string repo,
            string tagName,
            string owner2,

            global::LangSmith.RepoUpdateTagRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Tag<br/>
        /// Update a tag. Requires repo ownership, prompts:tag permission, or ABAC grant.
        /// </summary>
        /// <param name="owner1"></param>
        /// <param name="repo"></param>
        /// <param name="tagName"></param>
        /// <param name="owner2"></param>
        /// <param name="commitId"></param>
        /// <param name="skipWebhooks">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RepoTag> UpdateTagAsync(
            string owner1,
            string repo,
            string tagName,
            string owner2,
            global::System.Guid commitId,
            global::LangSmith.AnyOf<bool?, global::System.Collections.Generic.IList<global::System.Guid>>? skipWebhooks = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}