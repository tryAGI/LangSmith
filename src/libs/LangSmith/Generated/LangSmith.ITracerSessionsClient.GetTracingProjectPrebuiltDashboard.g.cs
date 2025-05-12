#nullable enable

namespace LangSmith
{
    public partial interface ITracerSessionsClient
    {
        /// <summary>
        /// Get Tracing Project Prebuilt Dashboard<br/>
        /// Get a prebuilt dashboard for a tracing project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="accept"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> GetTracingProjectPrebuiltDashboardAsync(
            global::System.Guid sessionId,
            global::LangSmith.CustomChartsSectionRequest request,
            string? accept = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Tracing Project Prebuilt Dashboard<br/>
        /// Get a prebuilt dashboard for a tracing project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="accept"></param>
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
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> GetTracingProjectPrebuiltDashboardAsync(
            global::System.Guid sessionId,
            string? accept = default,
            string? timezone = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::LangSmith.TimedeltaInput? stride = default,
            bool? omitData = default,
            global::LangSmith.RunStatsGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}