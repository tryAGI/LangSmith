#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Create evaluator<br/>
        /// Create a new LLM or code evaluator for the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsCreateEvaluatorResponse> CreateEvaluatorAsync(

            global::LangSmith.EvaluatorsCreateEvaluatorRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create evaluator<br/>
        /// Create a new LLM or code evaluator for the current workspace.
        /// </summary>
        /// <param name="codeEvaluator"></param>
        /// <param name="llmEvaluator"></param>
        /// <param name="name"></param>
        /// <param name="type"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsCreateEvaluatorResponse> CreateEvaluatorAsync(
            global::LangSmith.EvaluatorsCreateCodeEvaluatorRequest? codeEvaluator = default,
            global::LangSmith.EvaluatorsCreateLLMEvaluatorRequest? llmEvaluator = default,
            string? name = default,
            global::LangSmith.EvaluatorsEvaluatorType? type = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}