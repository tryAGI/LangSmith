#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Read Feedback<br/>
        /// Get a specific feedback.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="includeUserNames"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> ReadFeedbackAsync(
            global::System.Guid feedbackId,
            bool? includeUserNames = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}