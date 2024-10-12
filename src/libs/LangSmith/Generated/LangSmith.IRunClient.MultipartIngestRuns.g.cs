#nullable enable

namespace LangSmith
{
    public partial interface IRunClient
    {
        /// <summary>
        /// Multipart Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> MultipartIngestRunsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}