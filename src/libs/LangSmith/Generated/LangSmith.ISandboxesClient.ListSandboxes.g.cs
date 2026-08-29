#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List sandboxes<br/>
        /// List sandboxes for the authenticated tenant, with optional filtering, sorting, and pagination.<br/>
        /// Page with page_size and cursor: replay the response's next_cursor until it comes back null, which is the only signal that no pages remain.<br/>
        /// Cursors are opaque and only valid on this endpoint; do not parse or construct one.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="nameContains"></param>
        /// <param name="status"></param>
        /// <param name="createdBy"></param>
        /// <param name="label"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesSandboxListResponse> ListSandboxesAsync(
            int? pageSize = default,
            string? cursor = default,
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            string? status = default,
            string? createdBy = default,
            global::System.Collections.Generic.IList<string>? label = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List sandboxes<br/>
        /// List sandboxes for the authenticated tenant, with optional filtering, sorting, and pagination.<br/>
        /// Page with page_size and cursor: replay the response's next_cursor until it comes back null, which is the only signal that no pages remain.<br/>
        /// Cursors are opaque and only valid on this endpoint; do not parse or construct one.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="nameContains"></param>
        /// <param name="status"></param>
        /// <param name="createdBy"></param>
        /// <param name="label"></param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortOrder">
        /// Default Value: desc
        /// </param>
        /// <param name="sortDirection">
        /// Default Value: desc
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesSandboxListResponse>> ListSandboxesAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            string? status = default,
            string? createdBy = default,
            global::System.Collections.Generic.IList<string>? label = default,
            string? sortBy = default,
            string? sortOrder = default,
            string? sortDirection = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}