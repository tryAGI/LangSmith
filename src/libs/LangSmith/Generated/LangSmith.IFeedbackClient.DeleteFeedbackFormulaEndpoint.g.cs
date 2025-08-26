#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Delete Feedback Formula Endpoint
        /// </summary>
        /// <param name="feedbackFormulaId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteFeedbackFormulaEndpointAsync(
            global::System.Guid feedbackFormulaId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}