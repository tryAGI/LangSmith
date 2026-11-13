#nullable enable

namespace LangSmith
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Put Org Default Usage Limit<br/>
        /// Set the organization's default monthly trace limit for new workspaces; with `apply_to`, also update existing workspaces without their own limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrgDefaultMonthlyTraceLimit> PutOrgDefaultUsageLimitAsync(

            global::LangSmith.UpdateOrgDefaultMonthlyTraceLimit request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Org Default Usage Limit<br/>
        /// Set the organization's default monthly trace limit for new workspaces; with `apply_to`, also update existing workspaces without their own limit.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OrgDefaultMonthlyTraceLimit>> PutOrgDefaultUsageLimitAsResponseAsync(

            global::LangSmith.UpdateOrgDefaultMonthlyTraceLimit request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Org Default Usage Limit<br/>
        /// Set the organization's default monthly trace limit for new workspaces; with `apply_to`, also update existing workspaces without their own limit.
        /// </summary>
        /// <param name="limitValue"></param>
        /// <param name="applyTo"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrgDefaultMonthlyTraceLimit> PutOrgDefaultUsageLimitAsync(
            int limitValue,
            global::LangSmith.OrgDefaultApplyTo? applyTo = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}