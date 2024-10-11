#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            global::LangSmith.FeedbackCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
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
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            global::LangSmith.AnyOf<double?, int?, bool?, object>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>? value = default,
            global::LangSmith.AnyOf<string, object>? comment = default,
            global::LangSmith.AnyOf<object, string, object>? correction = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? feedbackGroupId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? runId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::System.Guid? id = default,
            global::LangSmith.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource, object>? feedbackSource = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}