#nullable enable

namespace LangSmith
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// List commits<br/>
        /// Lists all commits for a repository with pagination support.<br/>
        /// This endpoint supports both authenticated and unauthenticated access.<br/>
        /// Authenticated users can access private repos, while unauthenticated users can only access public repos.<br/>
        /// The include_stats parameter controls whether download and view statistics are computed (defaults to true).
        /// </summary>
        /// <param name="includeStats">
        /// Default Value: true
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CommitsListCommitsResponse> ListCommitsAsync(
            bool? includeStats = default,
            int? limit = default,
            int? offset = default,
            string? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}