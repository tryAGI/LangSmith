#nullable enable

namespace LangSmith
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Read Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SessionFeedbackDelta> ReadDeltaAsync(
            global::System.Guid datasetId,
            global::LangSmith.QueryFeedbackDelta request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Read Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SessionFeedbackDelta> ReadDeltaAsync(
            global::System.Guid datasetId,
            global::System.Guid baselineSessionId,
            global::System.Collections.Generic.IList<global::System.Guid> comparisonSessionIds,
            string feedbackKey,
            global::LangSmith.AnyOf<global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>, object>? filters = default,
            int? offset = 0,
            int? limit = 100,
            global::LangSmith.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}