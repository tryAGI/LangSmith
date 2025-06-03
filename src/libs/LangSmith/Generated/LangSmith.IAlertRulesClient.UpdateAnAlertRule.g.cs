#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Update an alert rule<br/>
        /// Updates an alert rule.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnAlertRuleAsync(
            global::LangSmith.AlertsUpdateAlertRuleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an alert rule<br/>
        /// Updates an alert rule.
        /// </summary>
        /// <param name="actions"></param>
        /// <param name="rule"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnAlertRuleAsync(
            global::System.Collections.Generic.IList<global::LangSmith.AlertsAlertActionBase> actions,
            global::LangSmith.AlertsAlertRuleBase rule,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}