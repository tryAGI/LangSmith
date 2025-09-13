#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Delete Insights Job Config<br/>
        /// Delete a clustering job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="configId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteClusteringJobConfigResponse> [Beta]DeleteInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::System.Guid configId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}