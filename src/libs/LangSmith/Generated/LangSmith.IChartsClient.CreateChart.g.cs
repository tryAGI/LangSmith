#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> CreateChartAsync(
            global::LangSmith.CustomChartCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Chart<br/>
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> CreateChartAsync(
            string title,
            global::LangSmith.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate> series,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<int?, object>? index = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sectionId = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartCreateMetadata, object>? metadata = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, object>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}