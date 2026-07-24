#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Get evaluator spend<br/>
        /// Returns per-day LLM evaluator spend for the requested 7-day period, grouped by evaluator, resource, or run rule. Exactly one of group_by, evaluator_id, session_id, or dataset_id is required. resource_id, type, and feedback_key may be supplied with group_by to narrow listing aggregations.
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="datasetId"></param>
        /// <param name="resourceId"></param>
        /// <param name="type"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="periodStart"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsGetEvaluatorSpendResponse> GetEvaluatorSpendAsync(
            string periodStart,
            string? groupBy = default,
            string? evaluatorId = default,
            string? sessionId = default,
            string? datasetId = default,
            global::System.Collections.Generic.IList<string>? resourceId = default,
            string? type = default,
            string? feedbackKey = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get evaluator spend<br/>
        /// Returns per-day LLM evaluator spend for the requested 7-day period, grouped by evaluator, resource, or run rule. Exactly one of group_by, evaluator_id, session_id, or dataset_id is required. resource_id, type, and feedback_key may be supplied with group_by to narrow listing aggregations.
        /// </summary>
        /// <param name="groupBy"></param>
        /// <param name="evaluatorId"></param>
        /// <param name="sessionId"></param>
        /// <param name="datasetId"></param>
        /// <param name="resourceId"></param>
        /// <param name="type"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="periodStart"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.EvaluatorsGetEvaluatorSpendResponse>> GetEvaluatorSpendAsResponseAsync(
            string periodStart,
            string? groupBy = default,
            string? evaluatorId = default,
            string? sessionId = default,
            string? datasetId = default,
            global::System.Collections.Generic.IList<string>? resourceId = default,
            string? type = default,
            string? feedbackKey = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}