#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Delete Insights Job Config<br/>
        /// Delete an insights job config.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="configId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.DeleteClusteringJobConfigResponse> DeleteInsightsJobConfigAsync(
            global::System.Guid sessionId,
            global::System.Guid configId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}