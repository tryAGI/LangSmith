#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Delete Job<br/>
        /// Delete a prompt optimization job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner1"></param>
        /// <param name="repo1"></param>
        /// <param name="owner2"></param>
        /// <param name="repo2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteJobAsync(
            global::System.Guid jobId,
            string owner1,
            string repo1,
            string owner2,
            string repo2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}