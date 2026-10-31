#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// List data planes for the current organization<br/>
        /// Returns up to 50 data planes owned by the caller's organization across all lifecycle states. Sorted by status priority (active first), then newest first. Requires BYOC to be enabled for the org.<br/>
        /// Omit view or use view=FULL for the full response (requires organization:infrastructure:read). view=SUMMARY returns only id, name, api_url, status, and workspaces and requires organization:read or organization:infrastructure:read. Without infrastructure read, workspace references are limited to the caller's memberships.
        /// </summary>
        /// <param name="view">
        /// Default Value: FULL
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesListPublicDataPlanesResponse> ListDataPlanesForTheCurrentOrganizationAsync(
            global::LangSmith.GetOrgsCurrentDataPlanesView? view = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List data planes for the current organization<br/>
        /// Returns up to 50 data planes owned by the caller's organization across all lifecycle states. Sorted by status priority (active first), then newest first. Requires BYOC to be enabled for the org.<br/>
        /// Omit view or use view=FULL for the full response (requires organization:infrastructure:read). view=SUMMARY returns only id, name, api_url, status, and workspaces and requires organization:read or organization:infrastructure:read. Without infrastructure read, workspace references are limited to the caller's memberships.
        /// </summary>
        /// <param name="view">
        /// Default Value: FULL
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DataPlanesListPublicDataPlanesResponse>> ListDataPlanesForTheCurrentOrganizationAsResponseAsync(
            global::LangSmith.GetOrgsCurrentDataPlanesView? view = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}