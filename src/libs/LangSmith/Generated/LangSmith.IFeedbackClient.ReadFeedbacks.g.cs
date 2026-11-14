#nullable enable

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Read Feedbacks<br/>
        /// List feedback, newest first.<br/>
        /// At least one of run, key, or session is required.
        /// </summary>
        /// <param name="run">
        /// Only feedback on these run IDs.
        /// </param>
        /// <param name="key">
        /// Only feedback with these keys.
        /// </param>
        /// <param name="session">
        /// Only feedback in these tracing project (session) IDs.
        /// </param>
        /// <param name="source">
        /// Only feedback from these source types: api, model, app, or auto_eval.
        /// </param>
        /// <param name="limit">
        /// The maximum number of feedback to return, 1 to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// The number of feedback to skip, for paging.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="user">
        /// Only feedback written by these user IDs.
        /// </param>
        /// <param name="hasComment">
        /// true returns only feedback with a non-empty comment; false only feedback without one.
        /// </param>
        /// <param name="hasScore">
        /// true returns only feedback with a score; false only feedback without one.
        /// </param>
        /// <param name="level">
        /// run returns only feedback on a run; session returns only feedback on a whole tracing project, and requires session.
        /// </param>
        /// <param name="maxCreatedAt">
        /// Only feedback created at or before this ISO 8601 time.
        /// </param>
        /// <param name="minCreatedAt">
        /// Only feedback created at or after this ISO 8601 time.
        /// </param>
        /// <param name="feedbackThreadId">
        /// Only feedback on this thread. Requires exactly one session and cannot be combined with run.
        /// </param>
        /// <param name="includeUserNames">
        /// Whether to add the author's name to each feedback's source.
        /// </param>
        /// <param name="comparativeExperimentId">
        /// Only feedback written for this comparative (pairwise) experiment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>> ReadFeedbacksAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? session = default,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::LangSmith.FeedbackLevel? level = default,
            global::System.DateTime? maxCreatedAt = default,
            global::System.DateTime? minCreatedAt = default,
            string? feedbackThreadId = default,
            bool? includeUserNames = default,
            global::System.Guid? comparativeExperimentId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Read Feedbacks<br/>
        /// List feedback, newest first.<br/>
        /// At least one of run, key, or session is required.
        /// </summary>
        /// <param name="run">
        /// Only feedback on these run IDs.
        /// </param>
        /// <param name="key">
        /// Only feedback with these keys.
        /// </param>
        /// <param name="session">
        /// Only feedback in these tracing project (session) IDs.
        /// </param>
        /// <param name="source">
        /// Only feedback from these source types: api, model, app, or auto_eval.
        /// </param>
        /// <param name="limit">
        /// The maximum number of feedback to return, 1 to 100.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="offset">
        /// The number of feedback to skip, for paging.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="user">
        /// Only feedback written by these user IDs.
        /// </param>
        /// <param name="hasComment">
        /// true returns only feedback with a non-empty comment; false only feedback without one.
        /// </param>
        /// <param name="hasScore">
        /// true returns only feedback with a score; false only feedback without one.
        /// </param>
        /// <param name="level">
        /// run returns only feedback on a run; session returns only feedback on a whole tracing project, and requires session.
        /// </param>
        /// <param name="maxCreatedAt">
        /// Only feedback created at or before this ISO 8601 time.
        /// </param>
        /// <param name="minCreatedAt">
        /// Only feedback created at or after this ISO 8601 time.
        /// </param>
        /// <param name="feedbackThreadId">
        /// Only feedback on this thread. Requires exactly one session and cannot be combined with run.
        /// </param>
        /// <param name="includeUserNames">
        /// Whether to add the author's name to each feedback's source.
        /// </param>
        /// <param name="comparativeExperimentId">
        /// Only feedback written for this comparative (pairwise) experiment.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.FeedbackSchema>>> ReadFeedbacksAsResponseAsync(
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? run = default,
            global::System.Collections.Generic.IList<string>? key = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, global::System.Guid?>? session = default,
            global::System.Collections.Generic.IList<global::LangSmith.SourceType>? source = default,
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<global::System.Guid>? user = default,
            bool? hasComment = default,
            bool? hasScore = default,
            global::LangSmith.FeedbackLevel? level = default,
            global::System.DateTime? maxCreatedAt = default,
            global::System.DateTime? minCreatedAt = default,
            string? feedbackThreadId = default,
            bool? includeUserNames = default,
            global::System.Guid? comparativeExperimentId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}