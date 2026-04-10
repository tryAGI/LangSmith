#nullable enable

namespace LangSmith
{
    public partial interface IExperimentsClient
    {
        /// <summary>
        /// Evaluate Experiment Adhoc<br/>
        /// Evaluate an existing experiment with a specific evaluator.<br/>
        /// This triggers immediate evaluation using the run_over_dataset approach,<br/>
        /// processing runs in batches to handle large experiments efficiently.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> EvaluateExperimentAdhocAsync(
            global::System.Guid experimentId,

            global::LangSmith.EvaluateExperimentRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate Experiment Adhoc<br/>
        /// Evaluate an existing experiment with a specific evaluator.<br/>
        /// This triggers immediate evaluation using the run_over_dataset approach,<br/>
        /// processing runs in batches to handle large experiments efficiently.
        /// </summary>
        /// <param name="experimentId"></param>
        /// <param name="ruleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> EvaluateExperimentAdhocAsync(
            global::System.Guid experimentId,
            global::System.Guid ruleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}