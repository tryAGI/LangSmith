#nullable enable

namespace LangSmith
{
    public partial interface IThreadsClient
    {
        /// <summary>
        /// Query Thread Traces<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Retrieve all traces belonging to a specific thread within a project.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cursor"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ThreadsQueryThreadTracesResponseBody> QueryThreadTracesAsync(
            string threadId,
            global::System.Guid projectId,
            string? cursor = default,
            string? filter = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Query Thread Traces<br/>
        /// **Alpha:** The request and response contract may change;<br/>
        /// Retrieve all traces belonging to a specific thread within a project.
        /// </summary>
        /// <param name="threadId"></param>
        /// <param name="cursor"></param>
        /// <param name="filter"></param>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="selects"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.ThreadsQueryThreadTracesResponseBody>> QueryThreadTracesAsResponseAsync(
            string threadId,
            global::System.Guid projectId,
            string? cursor = default,
            string? filter = default,
            int? pageSize = default,
            global::System.Collections.Generic.IList<global::LangSmith.GetThreadsTracesSelect>? selects = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}