#nullable enable

namespace LangSmith
{
    public partial interface IOptimizationJobsClient
    {
        /// <summary>
        /// List Jobs<br/>
        /// List all prompt optimization jobs.
        /// </summary>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PromptOptimizationJob>> ListJobsAsync(
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}