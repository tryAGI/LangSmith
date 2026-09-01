#nullable enable

namespace LangSmith
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations. Linked directories default to the LATEST selector; use COMMIT to pin one commit. The legacy commit_id write field is deprecated and resolves as LATEST.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DirectoryCommitResponse> CreateDirectoryCommitAsync(
            string owner,
            string repo,

            global::LangSmith.DirectoryCreateDirectoryCommitRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations. Linked directories default to the LATEST selector; use COMMIT to pin one commit. The legacy commit_id write field is deprecated and resolves as LATEST.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DirectoryCommitResponse>> CreateDirectoryCommitAsResponseAsync(
            string owner,
            string repo,

            global::LangSmith.DirectoryCreateDirectoryCommitRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations. Linked directories default to the LATEST selector; use COMMIT to pin one commit. The legacy commit_id write field is deprecated and resolves as LATEST.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="files">
        /// Paths to create, update, link, delete, or unlink. Use null to delete or unlink an existing path.
        /// </param>
        /// <param name="parentCommit"></param>
        /// <param name="skipWebhooks">
        /// SkipWebhooks suppresses Context Hub commit webhooks for this commit.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DirectoryCommitResponse> CreateDirectoryCommitAsync(
            string owner,
            string repo,
            object? files = default,
            string? parentCommit = default,
            bool? skipWebhooks = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}