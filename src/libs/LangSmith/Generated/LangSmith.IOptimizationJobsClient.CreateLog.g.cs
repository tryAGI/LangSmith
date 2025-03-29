#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// Create Log<br/>
        /// Create a new log entry for a prompt optimization job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJobLog> CreateLogAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::LangSmith.PromptOptimizationJobLogCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Log<br/>
        /// Create a new log entry for a prompt optimization job.
        /// </summary>
        /// <param name="jobId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="logType"></param>
        /// <param name="message"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptOptimizationJobLog> CreateLogAsync(
            global::System.Guid jobId,
            string owner,
            string repo,
            global::LangSmith.EPromptOptimizationJobLogType logType,
            string message,
            object? data = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}