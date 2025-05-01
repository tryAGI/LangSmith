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
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> GetTracingProjectPrebuiltDashboardAsync(
            global::System.Guid sessionId,
            global::LangSmith.CustomChartsSectionRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Get Tracing Project Prebuilt Dashboard<br/>
        /// Get a prebuilt dashboard for a tracing project.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
        /// <param name="groupBy">
        /// Group by param for run stats.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> GetTracingProjectPrebuiltDashboardAsync(
            global::System.Guid sessionId,
            global::System.DateTime startTime,
            string? timezone = default,
            global::System.DateTime? endTime = default,
            global::LangSmith.TimedeltaInput? stride = default,
            global::LangSmith.RunStatsGroupBy? groupBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}