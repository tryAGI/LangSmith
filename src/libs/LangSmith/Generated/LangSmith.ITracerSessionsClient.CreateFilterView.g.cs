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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,

            global::LangSmith.FilterViewCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.FilterView>> CreateFilterViewAsResponseAsync(
            global::System.Guid sessionId,

            global::LangSmith.FilterViewCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Filter View<br/>
        /// Create a new filter view.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="description"></param>
        /// <param name="displayName"></param>
        /// <param name="duration"></param>
        /// <param name="endTime"></param>
        /// <param name="filterString"></param>
        /// <param name="startTime"></param>
        /// <param name="syntaxVersion">
        /// Default Value: 1
        /// </param>
        /// <param name="threadFilterString"></param>
        /// <param name="traceFilterString"></param>
        /// <param name="treeFilterString"></param>
        /// <param name="type">
        /// Default Value: runs
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FilterView> CreateFilterViewAsync(
            global::System.Guid sessionId,
            string displayName,
            string? description = default,
            string? duration = default,
            global::System.DateTime? endTime = default,
            string? filterString = default,
            global::System.DateTime? startTime = default,
            int? syntaxVersion = default,
            string? threadFilterString = default,
            string? traceFilterString = default,
            string? treeFilterString = default,
            global::LangSmith.FilterViewCreateType? type = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}