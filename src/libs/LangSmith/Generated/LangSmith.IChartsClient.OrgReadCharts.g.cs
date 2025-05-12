#nullable enable

namespace LangSmith
{
    public partial interface IChartsClient
    {
        /// <summary>
        /// Org Read Charts<br/>
        /// Get all charts for the tenant.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsResponse> OrgReadChartsAsync(
            global::LangSmith.CustomChartsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Org Read Charts<br/>
        /// Get all charts for the tenant.
        /// </summary>
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
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsResponse> OrgReadChartsAsync(
            string? timezone = default,
            global::System.DateTime? startTime = default,
            global::System.DateTime? endTime = default,
            global::LangSmith.TimedeltaInput? stride = default,
            bool? omitData = default,
            int? afterIndex = default,
            global::System.Collections.Generic.IList<global::System.Guid>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}