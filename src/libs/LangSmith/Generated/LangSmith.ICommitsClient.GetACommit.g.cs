#nullable enable

namespace LangSmith
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// Get a commit<br/>
        /// Retrieves a specific commit by hash, tag, or "latest" for a repository.<br/>
        /// This endpoint supports both authenticated and unauthenticated access.<br/>
        /// Authenticated users can access private repos, while unauthenticated users can only access public repos.<br/>
        /// Commit resolution logic:<br/>
        /// - "latest" or empty: Get the most recent commit<br/>
        /// - Less than 8 characters: Only check for tags<br/>
        /// - 8 or more characters: Prioritize commit hash over tag, check both
        /// </summary>
        /// <param name="getExamples">
        /// Default Value: false
        /// </param>
        /// <param name="includeModel">
        /// Default Value: false
        /// </param>
        /// <param name="isView">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CommitsCommitResponse> GetACommitAsync(
            bool? getExamples = default,
            bool? includeModel = default,
            bool? isView = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}