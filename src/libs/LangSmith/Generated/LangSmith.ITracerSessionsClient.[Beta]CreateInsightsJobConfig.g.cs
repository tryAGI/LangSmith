#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Create Insights Job Config<br/>
        /// Save a clustering job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateClusteringJobConfigResponse> [Beta]CreateInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::LangSmith.CreateClusteringJobConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// [Beta] Create Insights Job Config<br/>
        /// Save a clustering job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="name"></param>
        /// <param name="config">
        /// Request to create a run clustering job.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateClusteringJobConfigResponse> [Beta]CreateInsightsJobConfigAsync(
            global::System.Guid sessionId,
            string name,
            global::LangSmith.CreateRunClusteringJobRequest config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}