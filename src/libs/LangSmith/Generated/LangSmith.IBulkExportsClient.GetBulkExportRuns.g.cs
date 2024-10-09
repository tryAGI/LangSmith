#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Runs<br/>
        /// Get a bulk export's runs
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>> GetBulkExportRunsAsync(
            global::System.Guid bulkExportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}