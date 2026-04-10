#nullable enable

namespace LangSmith
{
    public partial interface IReposClient
    {
        /// <summary>
        /// Optimize Prompt Job<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptJobAsync(

            global::LangSmith.OptimizePromptJobRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Optimize Prompt Job<br/>
        /// Optimize prompt
        /// </summary>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="promptName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OptimizePromptResponse> OptimizePromptJobAsync(
            global::LangSmith.EPromptOptimizationAlgorithm algorithm,
            global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig> config,
            string promptName,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}