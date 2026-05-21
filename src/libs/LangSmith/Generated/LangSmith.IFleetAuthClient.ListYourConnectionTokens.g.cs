#nullable enable

namespace LangSmith
{
    public partial interface IFleetAuthClient
    {
        /// <summary>
        /// List your connection tokens<br/>
        /// Lists the active OAuth tokens belonging to the caller. Optionally filter by provider or agent. Accepts page_size and cursor for forward compatibility; pagination is not yet enforced and all matching tokens are returned in one page.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="isDefault"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthListTokensResponse> ListYourConnectionTokensAsync(
            string? providerId = default,
            bool? isDefault = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List your connection tokens<br/>
        /// Lists the active OAuth tokens belonging to the caller. Optionally filter by provider or agent. Accepts page_size and cursor for forward compatibility; pagination is not yet enforced and all matching tokens are returned in one page.
        /// </summary>
        /// <param name="providerId"></param>
        /// <param name="isDefault"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.AuthListTokensResponse>> ListYourConnectionTokensAsResponseAsync(
            string? providerId = default,
            bool? isDefault = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}