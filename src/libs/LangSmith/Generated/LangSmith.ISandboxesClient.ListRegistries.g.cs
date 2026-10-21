#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List registries<br/>
        /// List sandbox registries for pulling private images.<br/>
        /// Page with page_size and cursor, replaying next_cursor until it is null. Results are ordered newest first, with stable ordering for equal creation times. Keep filters unchanged between pages.<br/>
        /// Requests without page_size or cursor retain the legacy default of 50 results. Cursor requests default to 20 results, with a maximum of 100.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="nameContains"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesRegistryListResponse> ListRegistriesAsync(
            int? pageSize = default,
            string? cursor = default,
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List registries<br/>
        /// List sandbox registries for pulling private images.<br/>
        /// Page with page_size and cursor, replaying next_cursor until it is null. Results are ordered newest first, with stable ordering for equal creation times. Keep filters unchanged between pages.<br/>
        /// Requests without page_size or cursor retain the legacy default of 50 results. Cursor requests default to 20 results, with a maximum of 100.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="nameContains"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SandboxesRegistryListResponse>> ListRegistriesAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}