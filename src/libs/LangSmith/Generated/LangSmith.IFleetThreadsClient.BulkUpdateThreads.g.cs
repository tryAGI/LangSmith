#nullable enable

namespace LangSmith
{
    public partial interface IFleetThreadsClient
    {
        /// <summary>
        /// Bulk update threads<br/>
        /// Applies one thread update payload to multiple threads in a single call. `data` uses the same shape as the single-thread update payload. The request may include at most 50 thread IDs. Returns one result per thread in the same order as `thread_ids`; the overall response is 200 even when individual threads fail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsBulkUpdateThreadsResponse> BulkUpdateThreadsAsync(

            global::LangSmith.ThreadsBulkUpdateThreadsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update threads<br/>
        /// Applies one thread update payload to multiple threads in a single call. `data` uses the same shape as the single-thread update payload. The request may include at most 50 thread IDs. Returns one result per thread in the same order as `thread_ids`; the overall response is 200 even when individual threads fail.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsBulkUpdateThreadsResponse>> BulkUpdateThreadsAsResponseAsync(

            global::LangSmith.ThreadsBulkUpdateThreadsRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk update threads<br/>
        /// Applies one thread update payload to multiple threads in a single call. `data` uses the same shape as the single-thread update payload. The request may include at most 50 thread IDs. Returns one result per thread in the same order as `thread_ids`; the overall response is 200 even when individual threads fail.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="threadIds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsBulkUpdateThreadsResponse> BulkUpdateThreadsAsync(
            global::LangSmith.ThreadsUpdateThreadRequest? data = default,
            global::System.Collections.Generic.IList<string>? threadIds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}