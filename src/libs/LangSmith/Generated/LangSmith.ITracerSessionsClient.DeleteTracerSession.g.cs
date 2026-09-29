#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Delete Tracer Session<br/>
        /// Delete a specific project.<br/>
        /// Returns 202 when deletion is accepted. Cleanup runs asynchronously.<br/>
        /// Location identifies the affected project, not a cleanup-status endpoint.<br/>
        /// For a caller with read access, GET at that URL returns 200 with the project<br/>
        /// while it is still available, or 404 after the project is removed. A 404 does<br/>
        /// not confirm that background trace cleanup has finished. Polling for cleanup<br/>
        /// completion is not supported.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTracerSessionAsync(
            global::System.Guid sessionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Tracer Session<br/>
        /// Delete a specific project.<br/>
        /// Returns 202 when deletion is accepted. Cleanup runs asynchronously.<br/>
        /// Location identifies the affected project, not a cleanup-status endpoint.<br/>
        /// For a caller with read access, GET at that URL returns 200 with the project<br/>
        /// while it is still available, or 404 after the project is removed. A 404 does<br/>
        /// not confirm that background trace cleanup has finished. Polling for cleanup<br/>
        /// completion is not supported.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteTracerSessionAsResponseAsync(
            global::System.Guid sessionId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}