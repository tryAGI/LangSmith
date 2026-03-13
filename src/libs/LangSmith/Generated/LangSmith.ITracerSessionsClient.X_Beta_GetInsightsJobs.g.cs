#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Get Insights Jobs<br/>
        /// Get all clusters for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="configId"></param>
        /// <param name="legacy"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetRunClusteringJobsResponse> X_Beta_GetInsightsJobsAsync(
            global::System.Guid sessionId,
            int? limit = default,
            int? offset = default,
            global::System.Guid? configId = default,
            bool? legacy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}