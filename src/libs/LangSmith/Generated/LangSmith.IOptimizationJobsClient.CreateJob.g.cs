#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Create Job<br/>
        /// Create a new prompt optimization job.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJob> CreateJobAsync(
            string repo,
            global::LangSmith.PromptOptimizationJobCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Job<br/>
        /// Create a new prompt optimization job.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="algorithm"></param>
        /// <param name="config"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJob> CreateJobAsync(
            string repo,
            global::LangSmith.EPromptOptimizationAlgorithm algorithm,
            global::LangSmith.AnyOf<global::LangSmith.PromptimConfig, global::LangSmith.DemoConfig> config,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}