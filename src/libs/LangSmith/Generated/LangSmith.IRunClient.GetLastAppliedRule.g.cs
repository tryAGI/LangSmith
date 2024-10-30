#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Get Last Applied Rule<br/>
        /// Get the last applied rule.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RuleLogSchema> GetLastAppliedRuleAsync(
            global::System.Guid ruleId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}