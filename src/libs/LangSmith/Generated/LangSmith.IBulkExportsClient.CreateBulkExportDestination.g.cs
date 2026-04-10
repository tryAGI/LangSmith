#nullable enable

namespace LangSmith
{
    public partial interface IBulkExportsClient
    {
        /// <summary>
        /// Create Bulk Export Destination<br/>
        /// Create a new bulk export destination
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportDestination> CreateBulkExportDestinationAsync(

            global::LangSmith.BulkExportDestinationCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Bulk Export Destination<br/>
        /// Create a new bulk export destination
        /// </summary>
        /// <param name="destinationType">
        /// Default Value: s3
        /// </param>
        /// <param name="displayName"></param>
        /// <param name="config"></param>
        /// <param name="credentials"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.BulkExportDestination> CreateBulkExportDestinationAsync(
            string displayName,
            global::LangSmith.BulkExportDestinationS3Config config,
            global::LangSmith.BulkExportDestinationType? destinationType = default,
            global::LangSmith.BulkExportDestinationS3Credentials? credentials = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}