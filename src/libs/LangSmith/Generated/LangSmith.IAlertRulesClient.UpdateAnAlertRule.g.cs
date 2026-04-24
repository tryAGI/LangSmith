#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Update an alert rule<br/>
        /// Updates an alert rule.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="alertRuleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnAlertRuleAsync(
            string sessionId,
            string alertRuleId,

            global::LangSmith.AlertsUpdateAlertRuleRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update an alert rule<br/>
        /// Updates an alert rule.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="alertRuleId"></param>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnAlertRuleAsync(
            string sessionId,
            string alertRuleId,
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> actions,
            global::LangSmith.AlertsAlertRuleBase rule,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}