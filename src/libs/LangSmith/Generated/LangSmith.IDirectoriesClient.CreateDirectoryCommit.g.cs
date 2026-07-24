#nullable enable

namespace LangSmith
{
    public partial interface IDirectoriesClient
    {
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DirectoriesCommitResponse> CreateDirectoryCommitAsync(
            string owner,
            string repo,

            global::LangSmith.DirectoriesCreateDirectoryCommitRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DirectoriesCommitResponse>> CreateDirectoryCommitAsResponseAsync(
            string owner,
            string repo,

            global::LangSmith.DirectoriesCreateDirectoryCommitRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create directory commit<br/>
        /// Creates a new directory commit for an agent or skill repository by applying file/link create, update, and delete operations.
        /// </summary>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="files">
        /// Files maps path to an Entry (object = create/update/link, null = delete/unlink).
        /// </param>
        /// <param name="parentCommit"></param>
        /// <param name="skipWebhooks">
        /// SkipWebhooks, when true, suppresses Context Hub commit webhooks for this<br/>
        /// commit. Deliberately a plain bool, not the any (bool | []string) shape of<br/>
        /// the prompt-hub CreateCommitReq.SkipWebhooks: Context Hub v1 has no<br/>
        /// per-webhook filtering, so a bool is the correct shape.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DirectoriesCommitResponse> CreateDirectoryCommitAsync(
            string owner,
            string repo,
            object? files = default,
            string? parentCommit = default,
            bool? skipWebhooks = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}