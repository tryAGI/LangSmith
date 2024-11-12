#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::LangSmith.FeedbackCreateWithTokenExtendedSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::LangSmith.AnyOf<double?, int?, bool?>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string>? value = default,
            string? comment = default,
            global::LangSmith.AnyOf<object, string>? correction = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}