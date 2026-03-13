#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Auto-Generate Insights Job Config<br/>
        /// Auto-generate an insights job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GenerateClusteringJobConfigResponse> X_Beta_AutoGenerateInsightsJobConfigAsync(
            global::System.Guid sessionId,

            global::LangSmith.GenerateClusteringJobConfigRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// [Beta] Auto-Generate Insights Job Config<br/>
        /// Auto-generate an insights job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="userContext"></param>
        /// <param name="model">
        /// Default Value: openai
        /// </param>
        /// <param name="clusterModel"></param>
        /// <param name="summaryModel"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.GenerateClusteringJobConfigResponse> X_Beta_AutoGenerateInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::System.Collections.Generic.Dictionary<string, string> userContext,
            global::LangSmith.GenerateClusteringJobConfigRequestModel? model = default,
            string? clusterModel = default,
            string? summaryModel = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}