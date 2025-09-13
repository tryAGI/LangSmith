#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Get Insights Job Configs<br/>
        /// Get all clustering job configs for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="includePrebuilts">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GetClusteringJobConfigsResponse> [Beta]GetInsightsJobConfigsAsync(
            global::System.Guid sessionId,
            bool? includePrebuilts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}