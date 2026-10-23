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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,

            global::LangSmith.FilterViewUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.FilterView>> UpdateFilterViewAsResponseAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,

            global::LangSmith.FilterViewUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Filter View<br/>
        /// Update a filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="viewId"></param>
        /// <param name="description"></param>
        /// <param name="displayName"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="filterString"></param>
        /// <param name="startTime"></param>
        /// <param name="syntaxVersion"></param>
        /// <param name="threadFilterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> UpdateFilterViewAsync(
            global::System.Guid sessionId,
            global::System.Guid viewId,
            string? description = default,
            string? displayName = default,
            string? duration = default,
            global::System.DateTime? endTime = default,
            string? filterString = default,
            global::System.DateTime? startTime = default,
            int? syntaxVersion = default,
            string? threadFilterString = default,
            string? traceFilterString = default,
            string? treeFilterString = default,
            global::LangSmith.FilterViewUpdateType? type = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}