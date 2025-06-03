#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Ingest Feedback (Batch JSON)<br/>
        /// Ingests a batch of feedback objects in a single JSON array payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> IngestFeedbackBatchJSONAsync(
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackFeedbackCreateSchema> request,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}