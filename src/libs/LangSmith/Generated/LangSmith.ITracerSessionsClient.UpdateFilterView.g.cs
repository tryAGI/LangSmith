#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            global::LangSmith.FilterViewUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="filterString"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            global::LangSmith.AnyOf<string, object>? filterString = default,
            global::LangSmith.AnyOf<string, object>? displayName = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<string, object>? traceFilterString = default,
            global::LangSmith.AnyOf<string, object>? treeFilterString = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}