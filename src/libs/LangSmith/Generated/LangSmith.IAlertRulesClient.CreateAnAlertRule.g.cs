#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Create an alert rule<br/>
        /// Creates a new alert rule. The request body must be a JSON-encoded alert rule object that follows the CreateAlertRuleRequest schema.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AlertsAlertRuleResponse> CreateAnAlertRuleAsync(
            string sessionId,

            global::LangSmith.AlertsCreateAlertRuleRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an alert rule<br/>
        /// Creates a new alert rule. The request body must be a JSON-encoded alert rule object that follows the CreateAlertRuleRequest schema.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AlertsAlertRuleResponse> CreateAnAlertRuleAsync(
            string sessionId,
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> actions,
            global::LangSmith.AlertsAlertRuleBase rule,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}