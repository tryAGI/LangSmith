#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Update Tracer Session<br/>
        /// Update a project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSession> UpdateTracerSessionAsync(
            global::System.Guid sessionId,

            global::LangSmith.TracerSessionUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tracer Session<br/>
        /// Update a project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSession>> UpdateTracerSessionAsResponseAsync(
            global::System.Guid sessionId,

            global::LangSmith.TracerSessionUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Tracer Session<br/>
        /// Update a project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="traceTier"></param>
        /// <param name="longlivedTtlDays">
        /// Retention in days for traces while trace_tier is longlived. One of 30, 60, 90, 120, 150, 180, 240, 300, 365 or 400, up to the maximum of the deployment. Self-hosted also accepts its configured retention. The value is kept while trace_tier is shortlived. Null means the project uses the workspace retention. Omit the field to keep the current value.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSession> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDatasetId = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            global::LangSmith.TraceTier? traceTier = default,
            int? longlivedTtlDays = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}