#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// List data planes for the current organization<br/>
        /// Returns up to 50 data planes owned by the caller's organization. Sorted status priority (active first), then newest first. Requires BYOC to be enabled for the org.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesListPublicDataPlanesResponse> ListDataPlanesForTheCurrentOrganizationAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}