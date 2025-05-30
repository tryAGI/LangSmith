#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List Taggings
        /// </summary>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.TaggingsResponse>> ListTaggingsAsync(
            global::System.Guid? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}