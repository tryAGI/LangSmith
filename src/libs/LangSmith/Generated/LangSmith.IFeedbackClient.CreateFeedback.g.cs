#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            global::LangSmith.FeedbackCreateSchema request,
            bool? error = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            string key,
            bool? error = default,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            global::LangSmith.AnyOf<double?, int?, bool?>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object>? value = default,
            string? comment = default,
            global::LangSmith.AnyOf<object, string>? correction = default,
            global::System.Guid? feedbackGroupId = default,
            global::System.Guid? comparativeExperimentId = default,
            global::System.Guid? runId = default,
            global::System.Guid? sessionId = default,
            global::System.Guid? id = default,
            global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource>? feedbackSource = default,
            global::LangSmith.FeedbackConfig? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}