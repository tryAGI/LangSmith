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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSection> ReadSingleSectionAsync(
            global::System.Guid sectionId,

            global::LangSmith.CustomChartsSectionRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
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
        /// Timedelta input.<br/>
        /// Default Value: {"days":0,"hours":0,"minutes":15}
        /// </param>
        /// <param name="omitData">
        /// Default Value: false
        /// </param>
        /// <param name="groupBy"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
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
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}