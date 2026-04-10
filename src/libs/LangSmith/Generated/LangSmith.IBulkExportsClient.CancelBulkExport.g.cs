#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Cancel Bulk Export<br/>
        /// Cancel a bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,

            global::LangSmith.BulkExportUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Cancel Bulk Export<br/>
        /// Cancel a bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="status">
        /// Default Value: Cancelled
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,
            global::LangSmith.BulkExportUpdatableStatus? status = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}