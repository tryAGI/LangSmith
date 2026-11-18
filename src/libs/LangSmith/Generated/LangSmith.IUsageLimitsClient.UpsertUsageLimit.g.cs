#nullable enable

namespace LangSmith
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Upsert Usage Limit<br/>
        /// Create or replace a usage limit and its alert thresholds.<br/>
        /// `alert_thresholds` replaces the stored list; omitting it clears the thresholds. To keep alerts without enforcing a limit, set `limit_value` to -1 and send `COUNT` thresholds; `PERCENT` thresholds need a limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageLimit> UpsertUsageLimitAsync(

            global::LangSmith.UpsertUsageLimit request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Usage Limit<br/>
        /// Create or replace a usage limit and its alert thresholds.<br/>
        /// `alert_thresholds` replaces the stored list; omitting it clears the thresholds. To keep alerts without enforcing a limit, set `limit_value` to -1 and send `COUNT` thresholds; `PERCENT` thresholds need a limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.UsageLimit>> UpsertUsageLimitAsResponseAsync(

            global::LangSmith.UpsertUsageLimit request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert Usage Limit<br/>
        /// Create or replace a usage limit and its alert thresholds.<br/>
        /// `alert_thresholds` replaces the stored list; omitting it clears the thresholds. To keep alerts without enforcing a limit, set `limit_value` to -1 and send `COUNT` thresholds; `PERCENT` thresholds need a limit.
        /// </summary>
        /// <param name="limitType">
        /// Type of usage limit.
        /// </param>
        /// <param name="limitValue"></param>
        /// <param name="id"></param>
        /// <param name="scope">
        /// Granularity a limit applies to within a tenant.<br/>
        /// Default Value: workspace
        /// </param>
        /// <param name="sessionId"></param>
        /// <param name="identityId"></param>
        /// <param name="alertThresholds">
        /// Usage levels that send an alert, at most one per `kind`. Omitting this field or sending an empty list removes all alert thresholds.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.UsageLimit> UpsertUsageLimitAsync(
            global::LangSmith.UsageLimitType limitType,
            int limitValue,
            global::System.Guid? id = default,
            global::LangSmith.UsageLimitScope? scope = default,
            global::System.Guid? sessionId = default,
            global::System.Guid? identityId = default,
            global::System.Collections.Generic.IList<global::LangSmith.AlertThreshold>? alertThresholds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}