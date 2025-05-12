#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> ReadSingleSectionAsync(
            global::System.Guid sectionId,
            global::LangSmith.CustomChartsSectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Single Section<br/>
        /// Get a single section by ID.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy">
        /// Group by param for run stats.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> ReadSingleSectionAsync(
            global::System.Guid sectionId,
            string? timezone = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::LangSmith.TimedeltaInput? stride = default,
            bool? omitData = default,
            global::LangSmith.RunStatsGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}