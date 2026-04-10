#nullable enable

namespace LangSmith
{
    public partial interface IPublicClient
    {
        /// <summary>
        /// Read Shared Delta Stream<br/>
        /// Stream feedback deltas for multiple feedback keys.<br/>
        /// Returns results in chunks as they become available. Each chunk contains<br/>
        /// results for one or more feedback keys. Errors for individual chunks are<br/>
        /// included in the response rather than failing the entire operation.<br/>
        /// Response format (SSE):<br/>
        ///     event: data<br/>
        ///     data: {"feedback_deltas": {"key1": {session_id: {...}}, ...}, "errors": null}<br/>
        ///     event: data<br/>
        ///     data: {"feedback_deltas": {"key2": {...}}, "errors": null}<br/>
        ///     event: end
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadSharedDeltaStreamAsync(
            global::System.Guid shareToken,

            global::LangSmith.QueryFeedbackDeltaBatch request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Shared Delta Stream<br/>
        /// Stream feedback deltas for multiple feedback keys.<br/>
        /// Returns results in chunks as they become available. Each chunk contains<br/>
        /// results for one or more feedback keys. Errors for individual chunks are<br/>
        /// included in the response rather than failing the entire operation.<br/>
        /// Response format (SSE):<br/>
        ///     event: data<br/>
        ///     data: {"feedback_deltas": {"key1": {session_id: {...}}, ...}, "errors": null}<br/>
        ///     event: data<br/>
        ///     data: {"feedback_deltas": {"key2": {...}}, "errors": null}<br/>
        ///     event: end
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ReadSharedDeltaStreamAsync(
            global::System.Guid shareToken,
            global::System.Guid baselineSessionId,
            global::System.Collections.Generic.IList<global::System.Guid> comparisonSessionIds,
            global::System.Collections.Generic.IList<string> feedbackKeys,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>? filters = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}