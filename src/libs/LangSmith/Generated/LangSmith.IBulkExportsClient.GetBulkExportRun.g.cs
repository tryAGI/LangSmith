#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Run<br/>
        /// Get a single bulk export's run by ID
        /// </summary>
        /// <param name="bulkExportId"></param>
        /// <param name="runId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportRun> GetBulkExportRunAsync(
            global::System.Guid bulkExportId,
            global::System.Guid runId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}