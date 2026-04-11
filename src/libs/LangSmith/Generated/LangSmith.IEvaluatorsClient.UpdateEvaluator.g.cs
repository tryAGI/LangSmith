#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Update evaluator<br/>
        /// Update an existing evaluator's name, LLM configuration, or code configuration.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsUpdateEvaluatorResponse> UpdateEvaluatorAsync(

            global::LangSmith.EvaluatorsUpdateEvaluatorRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update evaluator<br/>
        /// Update an existing evaluator's name, LLM configuration, or code configuration.
        /// </summary>
        /// <param name="codeEvaluator"></param>
        /// <param name="llmEvaluator"></param>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsUpdateEvaluatorResponse> UpdateEvaluatorAsync(
            global::LangSmith.EvaluatorsUpdateCodeEvaluatorRequest? codeEvaluator = default,
            global::LangSmith.EvaluatorsUpdateLLMEvaluatorRequest? llmEvaluator = default,
            string? name = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}