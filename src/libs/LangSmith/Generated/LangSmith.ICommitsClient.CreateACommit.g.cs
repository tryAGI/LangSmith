#nullable enable

namespace LangSmith
{
    public partial interface ICommitsClient
    {
        /// <summary>
        /// Create a commit<br/>
        /// Creates a new commit in a repository.<br/>
        /// Requires authentication and write access to the repository.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CommitsCreateCommitResponse> CreateACommitAsync(

            global::LangSmith.CommitsCreateCommitReq request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a commit<br/>
        /// Creates a new commit in a repository.<br/>
        /// Requires authentication and write access to the repository.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="manifest"></param>
        /// <param name="parentCommit"></param>
        /// <param name="skipWebhooks">
        /// SkipWebhooks allows skipping webhook notifications. Can be true (boolean) to skip all, or an array of webhook UUIDs to skip specific ones.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CommitsCreateCommitResponse> CreateACommitAsync(
            string? description = default,
            object? manifest = default,
            string? parentCommit = default,
            object? skipWebhooks = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}