#nullable enable

namespace LangSmith
{
    public partial interface IInfoClient
    {
        /// <summary>
        /// Get server info<br/>
        /// Returns information about the current LangSmith deployment: version,<br/>
        /// instance feature flags, batch-ingest limits, and max SDK versions.<br/>
        /// Unauthenticated by default; set FF_INFO_ENDPOINT_AUTH_REQUIRED=true to require auth.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.InfoInfoGetResponse> GetServerInfoAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get server info<br/>
        /// Returns information about the current LangSmith deployment: version,<br/>
        /// instance feature flags, batch-ingest limits, and max SDK versions.<br/>
        /// Unauthenticated by default; set FF_INFO_ENDPOINT_AUTH_REQUIRED=true to require auth.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.InfoInfoGetResponse>> GetServerInfoAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}