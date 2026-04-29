#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Get a single run<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Returns one run by ID for the given session and start_time. Use the `selects` query parameter (repeatable) to select fields to return.
        /// </summary>
        /// <param name="accept"></param>
        /// <param name="runId"></param>
        /// <param name="projectId"></param>
        /// <param name="selects"></param>
        /// <param name="startTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryRunResponse> GetASingleRunAsync(
            global::System.Guid runId,
            global::System.Guid projectId,
            global::System.DateTime startTime,
            string? accept = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetRunsSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}