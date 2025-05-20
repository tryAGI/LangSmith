#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Update an alert rule<br/>
        /// Updates an alert rule.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateAnAlertRuleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}