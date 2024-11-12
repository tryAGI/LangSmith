#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagValue> CreateTagValueAsync(
            global::System.Guid tagKeyId,
            global::LangSmith.TagValueCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tag Value
        /// </summary>
        /// <param name="tagKeyId"></param>
        /// <param name="value"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagValue> CreateTagValueAsync(
            global::System.Guid tagKeyId,
            string value,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}