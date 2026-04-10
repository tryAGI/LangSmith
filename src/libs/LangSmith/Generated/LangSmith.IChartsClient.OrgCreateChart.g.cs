#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> OrgCreateChartAsync(

            global::LangSmith.CustomChartCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Org Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> OrgCreateChartAsync(
            string title,
            global::LangSmith.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate> series,
            string? description = default,
            int? index = default,
            global::System.Guid? sectionId = default,
            object? metadata = default,
            global::LangSmith.CustomChartSeriesFilters2? commonFilters = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}