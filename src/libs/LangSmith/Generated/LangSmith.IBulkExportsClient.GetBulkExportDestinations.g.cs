#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Get Bulk Export Destinations<br/>
        /// Get the current workspace's bulk export destinations
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.BulkExportDestination>> GetBulkExportDestinationsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}