#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::LangSmith.CustomChartUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType"></param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? description = default,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series = default,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? sectionId = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing>? metadata = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}