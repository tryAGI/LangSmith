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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,
            global::LangSmith.BulkExportUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancel Bulk Export<br/>
        /// Cancel a bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="status"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExport> CancelBulkExportAsync(
            global::System.Guid bulkExportId,
            global::LangSmith.BulkExportUpdateStatus status = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}