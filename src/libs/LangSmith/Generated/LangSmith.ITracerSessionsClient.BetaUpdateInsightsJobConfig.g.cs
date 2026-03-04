#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Beta Update Insights Job Config<br/>
        /// Update an insights job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="configId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateClusteringJobConfigResponse> BetaUpdateInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::System.Guid configId,
            global::LangSmith.UpdateClusteringJobConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Beta Update Insights Job Config<br/>
        /// Update an insights job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="configId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="config">
        /// Request to create a run clustering job.
        /// </param>
        /// <param name="scheduleCron"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CreateClusteringJobConfigResponse> BetaUpdateInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::System.Guid configId,
            string? name = default,
            string? description = default,
            global::LangSmith.CreateRunClusteringJobRequest? config = default,
            string? scheduleCron = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}