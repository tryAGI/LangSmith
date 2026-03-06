#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Get Run Cluster From Insights Job<br/>
        /// Get a specific cluster for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="clusterId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRunClusterResponse> [Beta]GetRunClusterFromInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            global::System.Guid clusterId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}