#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List snapshots<br/>
        /// List sandbox snapshots for the authenticated tenant, with optional filtering, sorting, and pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="nameContains"></param>
        /// <param name="status"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSnapshotListResponse> ListSnapshotsAsync(
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            string? status = default,
            string? sortBy = default,
            string? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}