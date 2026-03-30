#nullable enable

namespace LangSmith
{
    public partial interface IEvaluatorsClient
    {
        /// <summary>
        /// Bulk delete evaluators<br/>
        /// Delete multiple evaluators by their IDs. Returns per-item success/failure.
        /// </summary>
        /// <param name="evaluatorIds"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.EvaluatorsBulkDeleteEvaluatorsResponse> BulkDeleteEvaluatorsAsync(
            byte[] evaluatorIds,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}