#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Get the LangSmith UI URL for a run<br/>
        /// Returns the URL to view a specific run in the LangSmith UI. The caller must supply the<br/>
        /// run's project_id and trace_id as query parameters; start_time is optional.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.QueryRunURLResponse> GetTheLangSmithUiUrlForARunAsync(
            global::System.Guid runId,
            string projectId,
            string traceId,
            string? startTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the LangSmith UI URL for a run<br/>
        /// Returns the URL to view a specific run in the LangSmith UI. The caller must supply the<br/>
        /// run's project_id and trace_id as query parameters; start_time is optional.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="projectId"></param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.QueryRunURLResponse>> GetTheLangSmithUiUrlForARunAsResponseAsync(
            global::System.Guid runId,
            string projectId,
            string traceId,
            string? startTime = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}