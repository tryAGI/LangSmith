#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Create Tag Key
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagKey> CreateTagKeyAsync(
            global::LangSmith.TagKeyCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Tag Key
        /// </summary>
        /// <param name="key"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagKey> CreateTagKeyAsync(
            string key,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}