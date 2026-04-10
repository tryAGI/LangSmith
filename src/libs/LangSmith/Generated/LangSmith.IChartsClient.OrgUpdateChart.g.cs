#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> OrgUpdateChartAsync(
            global::System.Guid chartId,

            global::LangSmith.CustomChartUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Org Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="title">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="description">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="index">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="chartType">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="series">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="sectionId">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="metadata">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="commonFilters">
        /// Default Value: {"__missing__":"__missing__"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> OrgUpdateChartAsync(
            global::System.Guid chartId,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description = default,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series = default,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? sectionId = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? metadata = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters2, global::LangSmith.Missing, object>? commonFilters = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}