#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Update Job<br/>
        /// Replace an existing prompt optimization job with a new, modified job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJob> UpdateJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::LangSmith.PromptOptimizationJobUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Job<br/>
        /// Replace an existing prompt optimization job with a new, modified job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="status"></param>
        /// <param name="result"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJob> UpdateJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::LangSmith.EPromptOptimizationJobStatus? status = default,
            global::LangSmith.PromptOptimizationResult? result = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}