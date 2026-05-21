#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Single Thread Stats<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Compute aggregate stats for a single thread (turn count, latency percentiles, token/cost sums, and detail breakdowns) within a project.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="selects"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody> QuerySingleThreadStatsAsync(
            string threadId,
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Single Thread Stats<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Compute aggregate stats for a single thread (turn count, latency percentiles, token/cost sums, and detail breakdowns) within a project.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="selects"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsQuerySingleThreadStatsResponseBody>> QuerySingleThreadStatsAsResponseAsync(
            string threadId,
            global::System.Guid sessionId,
            global::System.Collections.Generic.IList<global::LangSmith.GetThreadsStatsSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}