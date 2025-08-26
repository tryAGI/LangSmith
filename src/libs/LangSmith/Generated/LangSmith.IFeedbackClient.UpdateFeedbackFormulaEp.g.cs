#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Update Feedback Formula Ep
        /// </summary>
        /// <param name="feedbackFormulaId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackFormula> UpdateFeedbackFormulaEpAsync(
            global::System.Guid feedbackFormulaId,
            global::LangSmith.FeedbackFormulaUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Feedback Formula Ep
        /// </summary>
        /// <param name="feedbackFormulaId"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="aggregationType"></param>
        /// <param name="formulaParts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackFormula> UpdateFeedbackFormulaEpAsync(
            global::System.Guid feedbackFormulaId,
            string feedbackKey,
            global::LangSmith.FeedbackFormulaUpdateAggregationType aggregationType,
            global::System.Collections.Generic.IList<global::LangSmith.FeedbackFormulaWeightedVariable> formulaParts,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}