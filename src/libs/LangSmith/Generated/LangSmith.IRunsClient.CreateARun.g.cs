#nullable enable

namespace LangSmith
{
    public partial interface IRunsClient
    {
        /// <summary>
        /// Create a Run<br/>
        /// Queues a single run for ingestion. The request body must be a JSON-encoded run object that follows the Run schema.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateARunAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}