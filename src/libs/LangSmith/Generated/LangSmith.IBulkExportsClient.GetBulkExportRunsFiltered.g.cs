#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Runs Filtered<br/>
        /// Get all bulk export runs for exports that were created from a scheduled bulk export
        /// </summary>
        /// <param name="sourceBulkExportId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.BulkExportRun>> GetBulkExportRunsFilteredAsync(
            global::System.Guid sourceBulkExportId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}