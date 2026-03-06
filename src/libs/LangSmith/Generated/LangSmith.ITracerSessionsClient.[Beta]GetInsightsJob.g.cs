#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Get Insights Job<br/>
        /// Get a specific cluster job for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRunClusteringJobResponse> [Beta]GetInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}