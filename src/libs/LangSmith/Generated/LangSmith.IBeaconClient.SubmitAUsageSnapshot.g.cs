#nullable enable

namespace LangSmith
{
    public partial interface IBeaconClient
    {
        /// <summary>
        /// Submit a usage snapshot<br/>
        /// Records aggregate entity counts (workspaces, projects, datasets, active users, etc.)<br/>
        /// from a self-hosted deployment or BYOC data plane.<br/>
        /// Self-hosted authenticates via license_key in the body.<br/>
        /// BYOC data planes authenticate via the X-Data-Plane-Auth JWT header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitAUsageSnapshotAsync(

            global::LangSmith.BeaconSubmitUsageSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a usage snapshot<br/>
        /// Records aggregate entity counts (workspaces, projects, datasets, active users, etc.)<br/>
        /// from a self-hosted deployment or BYOC data plane.<br/>
        /// Self-hosted authenticates via license_key in the body.<br/>
        /// BYOC data planes authenticate via the X-Data-Plane-Auth JWT header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> SubmitAUsageSnapshotAsResponseAsync(

            global::LangSmith.BeaconSubmitUsageSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a usage snapshot<br/>
        /// Records aggregate entity counts (workspaces, projects, datasets, active users, etc.)<br/>
        /// from a self-hosted deployment or BYOC data plane.<br/>
        /// Self-hosted authenticates via license_key in the body.<br/>
        /// BYOC data planes authenticate via the X-Data-Plane-Auth JWT header.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="licenseKey"></param>
        /// <param name="measures"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitAUsageSnapshotAsync(
            string? fromTimestamp = default,
            string? licenseKey = default,
            global::System.Collections.Generic.Dictionary<string, int>? measures = default,
            string? toTimestamp = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}