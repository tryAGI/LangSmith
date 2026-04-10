#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponseBase> ReadChartPreviewAsync(

            global::LangSmith.CustomChartPreviewRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="bucketInfo"></param>
        /// <param name="chart"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponseBase> ReadChartPreviewAsync(
            global::LangSmith.CustomChartsRequestBase bucketInfo,
            global::LangSmith.CustomChartCreatePreview chart,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}