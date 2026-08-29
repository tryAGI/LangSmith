#nullable enable

namespace LangSmith
{
    public partial interface IDataPlanesClient
    {
        /// <summary>
        /// Update data plane settings<br/>
        /// Update specific settings for a data plane owned by the caller's organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> UpdateDataPlaneSettingsAsync(
            string id,

            global::LangSmith.DataPlanesUpdateDataPlaneRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update data plane settings<br/>
        /// Update specific settings for a data plane owned by the caller's organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.DataPlanesPublicDataPlane>> UpdateDataPlaneSettingsAsResponseAsync(
            string id,

            global::LangSmith.DataPlanesUpdateDataPlaneRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update data plane settings<br/>
        /// Update specific settings for a data plane owned by the caller's organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="maintenanceWindow">
        /// MaintenanceWindow is the two-hour weekly maintenance window in UTC.
        /// </param>
        /// <param name="ttl"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DataPlanesPublicDataPlane> UpdateDataPlaneSettingsAsync(
            string id,
            string? maintenanceWindow = default,
            global::LangSmith.DataPlanesUpdateDataPlaneTTLSettings? ttl = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}