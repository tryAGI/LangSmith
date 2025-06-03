#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Create an alert rule<br/>
        /// Creates a new alert rule. The request body must be a JSON-encoded alert rule object that follows the CreateAlertRuleRequest schema.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AlertsAlertRuleResponse> CreateAnAlertRuleAsync(
            global::LangSmith.AlertsCreateAlertRuleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create an alert rule<br/>
        /// Creates a new alert rule. The request body must be a JSON-encoded alert rule object that follows the CreateAlertRuleRequest schema.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AlertsAlertRuleResponse> CreateAnAlertRuleAsync(
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> actions,
            global::LangSmith.AlertsAlertRuleBase rule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}