#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,
            global::LangSmith.FilterViewCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="filterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="type"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,
            string displayName,
            string? filterString = default,
            string? traceFilterString = default,
            string? treeFilterString = default,
            string? description = default,
            global::LangSmith.FilterViewType? type = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}