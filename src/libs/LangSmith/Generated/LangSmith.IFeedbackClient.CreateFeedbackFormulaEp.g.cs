#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback Formula Ep
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackFormula> CreateFeedbackFormulaEpAsync(
            global::LangSmith.FeedbackFormulaCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback Formula Ep
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="sessionId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="aggregationType"></param>
        /// <param name="formulaParts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackFormula> CreateFeedbackFormulaEpAsync(
            string feedbackKey,
            global::LangSmith.FeedbackFormulaCreateAggregationType aggregationType,
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable> formulaParts,
            global::System.Guid? datasetId = default,
            global::System.Guid? sessionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}