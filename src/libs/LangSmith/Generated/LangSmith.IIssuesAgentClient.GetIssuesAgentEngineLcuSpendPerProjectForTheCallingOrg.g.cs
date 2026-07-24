#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// Get issues-agent (Engine) LCU spend per project for the calling org<br/>
        /// Returns the authoritative Engine LCU spend for the caller's<br/>
        /// organization in the window (`total_lcu`, independent of<br/>
        /// pagination). Set `group_by=tenant` for a workspace breakdown or<br/>
        /// `group_by=session` for a (tenant, session) breakdown — each<br/>
        /// spend-ranked and cursor-paginated (`page_size`, `cursor`); omit<br/>
        /// `group_by` for the total only. The window defaults to the current<br/>
        /// calendar month (UTC) and can be overridden with `start`/`end`<br/>
        /// (RFC 3339, capped at 31 days). Hours the rate card did not price<br/>
        /// are excluded from LCU and surfaced via the `*_unpriced_row_count`<br/>
        /// fields so callers can detect coverage gaps without inflating spend.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tenantId"></param>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IssuesAgentUsageLCUSpendResponse> GetIssuesAgentEngineLcuSpendPerProjectForTheCallingOrgAsync(
            string? start = default,
            string? end = default,
            string? tenantId = default,
            string? sessionId = default,
            string? groupBy = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get issues-agent (Engine) LCU spend per project for the calling org<br/>
        /// Returns the authoritative Engine LCU spend for the caller's<br/>
        /// organization in the window (`total_lcu`, independent of<br/>
        /// pagination). Set `group_by=tenant` for a workspace breakdown or<br/>
        /// `group_by=session` for a (tenant, session) breakdown — each<br/>
        /// spend-ranked and cursor-paginated (`page_size`, `cursor`); omit<br/>
        /// `group_by` for the total only. The window defaults to the current<br/>
        /// calendar month (UTC) and can be overridden with `start`/`end`<br/>
        /// (RFC 3339, capped at 31 days). Hours the rate card did not price<br/>
        /// are excluded from LCU and surfaced via the `*_unpriced_row_count`<br/>
        /// fields so callers can detect coverage gaps without inflating spend.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="tenantId"></param>
        /// <param name="sessionId"></param>
        /// <param name="groupBy"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.IssuesAgentUsageLCUSpendResponse>> GetIssuesAgentEngineLcuSpendPerProjectForTheCallingOrgAsResponseAsync(
            string? start = default,
            string? end = default,
            string? tenantId = default,
            string? sessionId = default,
            string? groupBy = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}