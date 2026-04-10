#nullable enable

namespace LangSmith
{
    public partial interface ITagTransitionsClient
    {
        /// <summary>
        /// Get tag transition history<br/>
        /// Returns the paginated audit log of transitions for a specific<br/>
        /// tag in a repository. Each entry records a commit change<br/>
        /// (from_commit → to_commit) along with who performed it.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TagTransitionsTagTransitionHistoryResponse> GetTagTransitionHistoryAsync(
            int? limit = default,
            int? offset = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}