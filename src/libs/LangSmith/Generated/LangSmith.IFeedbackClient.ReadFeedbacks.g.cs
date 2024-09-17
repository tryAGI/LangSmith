#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Read Feedbacks<br/>
        /// List all Feedback by query params.
        /// </summary>
        /// <param name="run"></param>
        /// <param name="key"></param>
        /// <param name="session"></param>
        /// <param name="source"></param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="user"></param>
        /// <param name="hasComment"></param>
        /// <param name="hasScore"></param>
        /// <param name="level"></param>
        /// <param name="maxCreatedAt"></param>
        /// <param name="minCreatedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadFeedbacksAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? run = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? session = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.SourceType>, object>? source = default,
            int? limit = 100,
            int? offset = 0,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? user = default,
            global::LangSmith.AnyOf<bool?, object>? hasComment = default,
            global::LangSmith.AnyOf<bool?, object>? hasScore = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackLevel?, object>? level = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? maxCreatedAt = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? minCreatedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}