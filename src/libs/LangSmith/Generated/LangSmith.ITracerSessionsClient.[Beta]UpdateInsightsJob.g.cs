#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Update Insights Job<br/>
        /// Update a session cluster job.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunClusteringJobResponse> [Beta]UpdateInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            global::LangSmith.UpdateRunClusteringJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// [Beta] Update Insights Job<br/>
        /// Update a session cluster job.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunClusteringJobResponse> [Beta]UpdateInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            string name,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}