#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> UpdateFeedbackAsync(
            global::System.Guid feedbackId,
            global::LangSmith.FeedbackUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Feedback<br/>
        /// Replace an existing feedback entry with a new, modified entry.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> UpdateFeedbackAsync(
            global::System.Guid feedbackId,
            global::LangSmith.AnyOf<double?, int?, bool?>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object>? value = default,
            string? comment = default,
            global::LangSmith.AnyOf<object, string>? correction = default,
            global::LangSmith.FeedbackConfig? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}