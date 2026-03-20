#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Get Job<br/>
        /// Get a specific optimization job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJobWithLogs> GetJobAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}