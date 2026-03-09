#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Delete Insights Job<br/>
        /// Delete a session cluster job.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteRunClusteringJobResponse> [Beta]DeleteInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}