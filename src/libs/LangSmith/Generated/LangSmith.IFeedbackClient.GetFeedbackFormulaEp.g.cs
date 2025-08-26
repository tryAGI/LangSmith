#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Get Feedback Formula Ep
        /// </summary>
        /// <param name="feedbackFormulaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackFormula> GetFeedbackFormulaEpAsync(
            global::System.Guid feedbackFormulaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}