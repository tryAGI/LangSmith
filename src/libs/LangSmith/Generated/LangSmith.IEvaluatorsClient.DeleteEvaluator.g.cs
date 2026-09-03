#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Delete evaluator<br/>
        /// Delete an evaluator. Returns 409 when a code evaluator build is ENQUEUED or BUILDING, or when run rules still reference the evaluator and delete_run_rules is false. When delete_run_rules is true, all run rules referencing this evaluator are deleted first (same tenant) if the build is not in flight. Associated llm_evaluators and code_evaluators rows are removed by foreign-key cascade when the evaluator row is deleted.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="deleteRunRules"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteEvaluatorAsync(
            string evaluatorId,
            bool? deleteRunRules = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete evaluator<br/>
        /// Delete an evaluator. Returns 409 when a code evaluator build is ENQUEUED or BUILDING, or when run rules still reference the evaluator and delete_run_rules is false. When delete_run_rules is true, all run rules referencing this evaluator are deleted first (same tenant) if the build is not in flight. Associated llm_evaluators and code_evaluators rows are removed by foreign-key cascade when the evaluator row is deleted.
        /// </summary>
        /// <param name="evaluatorId"></param>
        /// <param name="deleteRunRules"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteEvaluatorAsResponseAsync(
            string evaluatorId,
            bool? deleteRunRules = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}