#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Delete an alert rule<br/>
        /// Deletes an alert rule
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAnAlertRuleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}