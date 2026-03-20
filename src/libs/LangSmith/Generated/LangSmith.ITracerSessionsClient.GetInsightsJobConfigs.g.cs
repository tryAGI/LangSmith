#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {

        /// <summary>
        /// [Beta] Get Insights Job Configs<br/>
        /// Get all insights job configs for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="includePrebuilts">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.GetClusteringJobConfigsResponse> GetInsightsJobConfigsAsync(
            global::System.Guid sessionId,
            bool? includePrebuilts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}