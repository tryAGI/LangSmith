#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Delete Runs<br/>
        /// Delete specific runs by trace IDs or metadata key-value pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(

            global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Runs<br/>
        /// Delete specific runs by trace IDs or metadata key-value pairs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> DeleteRunsAsResponseAsync(

            global::LangSmith.BodyDeleteRunsApiV1RunsDeletePost request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Runs<br/>
        /// Delete specific runs by trace IDs or metadata key-value pairs.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="traceIds"></param>
        /// <param name="metadata"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteRunsAsync(
            global::System.Guid? sessionId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? traceIds = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}