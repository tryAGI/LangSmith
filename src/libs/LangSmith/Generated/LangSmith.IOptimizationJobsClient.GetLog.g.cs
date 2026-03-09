#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Get Log<br/>
        /// Get a specific prompt optimization job log.
        /// </summary>
        /// <param name="logId"></param>
        /// <param name="owner1"></param>
        /// <param name="repo1"></param>
        /// <param name="jobId1"></param>
        /// <param name="owner2"></param>
        /// <param name="repo2"></param>
        /// <param name="jobId2"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJobLog> GetLogAsync(
            global::System.Guid logId,
            string owner1,
            string repo1,
            string jobId1,
            string owner2,
            string repo2,
            global::System.Guid jobId2,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}