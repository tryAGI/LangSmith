#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// [Beta] Get Insights Job<br/>
        /// Get a specific cluster job for a session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "LANGSMITH_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::LangSmith.GetRunClusteringJobResponse> GetInsightsJobAsync(
            global::System.Guid sessionId,
            global::System.Guid jobId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}