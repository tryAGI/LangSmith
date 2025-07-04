#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Get an alert rule<br/>
        /// Gets an alert rule.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AlertsAlertRuleResponse> GetAnAlertRuleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}