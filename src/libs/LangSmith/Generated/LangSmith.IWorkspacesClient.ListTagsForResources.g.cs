#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Tags For Resources
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::LangSmith.TagKeyWithValuesAndTaggings>>> ListTagsForResourcesAsync(
            global::System.Collections.Generic.IList<global::LangSmith.ListTagsForResourceRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}