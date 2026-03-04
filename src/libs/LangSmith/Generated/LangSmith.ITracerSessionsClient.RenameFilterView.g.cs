#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Rename Filter View<br/>
        /// Rename a filter view (display_name and description only).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> RenameFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            global::LangSmith.FilterViewRename request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Rename Filter View<br/>
        /// Rename a filter view (display_name and description only).
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> RenameFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            string displayName,
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}