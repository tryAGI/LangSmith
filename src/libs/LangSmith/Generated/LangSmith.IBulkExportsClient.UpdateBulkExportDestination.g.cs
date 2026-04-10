#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Update Bulk Export Destination<br/>
        /// Update a bulk export destination
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportDestination> UpdateBulkExportDestinationAsync(
            global::System.Guid destinationId,

            global::LangSmith.BulkExportDestinationUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Bulk Export Destination<br/>
        /// Update a bulk export destination
        /// </summary>
        /// <param name="destinationId"></param>
        /// <param name="credentials"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportDestination> UpdateBulkExportDestinationAsync(
            global::System.Guid destinationId,
            global::LangSmith.BulkExportDestinationS3Credentials credentials,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}