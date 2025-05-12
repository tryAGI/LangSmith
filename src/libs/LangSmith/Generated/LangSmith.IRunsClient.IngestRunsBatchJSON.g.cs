#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Ingest Runs (Batch JSON)<br/>
        /// Ingests a batch of runs in a single JSON payload. The payload must have `post` and/or `patch` arrays containing run objects. \<br/>
        /// Prefer this endpoint over single‑run ingestion when submitting hundreds of runs, but `/runs/multipart` offers better handling for very large fields and attachments.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> IngestRunsBatchJSONAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}