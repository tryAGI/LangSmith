#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Destination<br/>
        /// Get a single bulk export destination by ID
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportDestination> GetBulkExportDestinationAsync(
            global::System.Guid destinationId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}