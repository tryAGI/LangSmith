#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponseBase> OrgReadChartPreviewAsync(
            global::LangSmith.CustomChartPreviewRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Read Chart Preview<br/>
        /// Get a preview for a chart without actually creating it.
        /// </summary>
        /// <param name="bucketInfo"></param>
        /// <param name="chart"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponseBase> OrgReadChartPreviewAsync(
            global::LangSmith.CustomChartsRequestBase bucketInfo,
            global::LangSmith.CustomChartCreatePreview chart,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}