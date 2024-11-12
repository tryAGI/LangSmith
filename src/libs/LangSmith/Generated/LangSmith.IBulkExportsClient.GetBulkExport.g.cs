#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export<br/>
        /// Get a single bulk export by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExport> GetBulkExportAsync(
            global::System.Guid bulkExportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}