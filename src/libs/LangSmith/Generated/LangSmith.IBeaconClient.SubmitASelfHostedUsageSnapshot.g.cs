#nullable enable

namespace LangSmith
{
    public partial interface IBeaconClient
    {
        /// <summary>
        /// Submit a self-hosted usage snapshot<br/>
        /// Records aggregate entity counts (workspaces, projects, datasets, active users, etc.)<br/>
        /// from a self-hosted deployment. Called daily by installs where PHONE_HOME_ENABLED<br/>
        /// and PHONE_HOME_USAGE_REPORTING_ENABLED are set. Authenticates via license key.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task SubmitASelfHostedUsageSnapshotAsync(

            global::LangSmith.BeaconSubmitUsageSnapshotPayload request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a self-hosted usage snapshot<br/>
        /// Records aggregate entity counts (workspaces, projects, datasets, active users, etc.)<br/>
        /// from a self-hosted deployment. Called daily by installs where PHONE_HOME_ENABLED<br/>
        /// and PHONE_HOME_USAGE_REPORTING_ENABLED are set. Authenticates via license key.
        /// </summary>
        /// <param name="fromTimestamp"></param>
        /// <param name="licenseKey"></param>
        /// <param name="measures"></param>
        /// <param name="toTimestamp"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task SubmitASelfHostedUsageSnapshotAsync(
            string? fromTimestamp = default,
            string? licenseKey = default,
            global::System.Collections.Generic.Dictionary<string, int>? measures = default,
            string? toTimestamp = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}