#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Delete Chart<br/>
        /// Delete a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OrgDeleteChartAsync(
            global::System.Guid chartId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}