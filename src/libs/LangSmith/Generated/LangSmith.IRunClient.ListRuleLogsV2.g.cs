#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// List Rule Logs V2<br/>
        /// List logs for a particular rule with cursor-based pagination.<br/>
        /// This endpoint handles S3-stored outcomes correctly by using run_outcomes_count<br/>
        /// to predict batch sizes and avoid over-fetching.
        /// </summary>
        /// <param name="ruleId"></param>
        /// <param name="limit">
        /// Default Value: 150
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="backfill">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="sessionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.RuleLogsPaginatedResponse> ListRuleLogsV2Async(
            global::System.Guid ruleId,
            int? limit = default,
            string? cursor = default,
            bool? backfill = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::System.Guid? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}