#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// List runs in a trace<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns runs for a trace ID within min/max start time. Optional `filter`; repeatable `selects` to select fields to return.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="traceId"></param>
        /// <param name="filter"></param>
        /// <param name="maxStartTime"></param>
        /// <param name="minStartTime"></param>
        /// <param name="projectId"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryQueryTraceResponseBody> ListRunsInATraceAsync(
            global::System.Guid traceId,
            global::System.DateTime maxStartTime,
            global::System.DateTime minStartTime,
            global::System.Guid projectId,
            string? accept = default,
            string? filter = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetTracesRunsSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}