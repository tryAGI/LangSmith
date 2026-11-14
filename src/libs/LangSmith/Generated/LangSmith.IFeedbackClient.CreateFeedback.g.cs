#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.<br/>
        /// `session_id` identifies the tracing project the feedback belongs to. It is<br/>
        /// required unless the feedback is addressed by `address`, which names that<br/>
        /// project through an Agent environment that already exists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(

            global::LangSmith.FeedbackCreateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.<br/>
        /// `session_id` identifies the tracing project the feedback belongs to. It is<br/>
        /// required unless the feedback is addressed by `address`, which names that<br/>
        /// project through an Agent environment that already exists.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.FeedbackSchema>> CreateFeedbackAsResponseAsync(

            global::LangSmith.FeedbackCreateSchema request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.<br/>
        /// `session_id` identifies the tracing project the feedback belongs to. It is<br/>
        /// required unless the feedback is addressed by `address`, which names that<br/>
        /// project through an Agent environment that already exists.
        /// </summary>
        /// <param name="createdAt">
        /// When the feedback was created, as an ISO 8601 timestamp. Defaults to now.
        /// </param>
        /// <param name="modifiedAt">
        /// When the feedback was last modified, as an ISO 8601 timestamp. Defaults to now.
        /// </param>
        /// <param name="key">
        /// The feedback key: the metric, tag, or aspect being scored, for example correctness.
        /// </param>
        /// <param name="score">
        /// The numeric or boolean score. Numbers must be between -99999.9999 and 99999.9999 with at most 4 decimal places.
        /// </param>
        /// <param name="value">
        /// A non-numeric value, such as a category label or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </param>
        /// <param name="comment">
        /// A free-text comment explaining the feedback. Truncated at the feedback size limit.
        /// </param>
        /// <param name="correction">
        /// The corrected output for the run, as a string or a JSON object. Dropped if it exceeds the feedback size limit.
        /// </param>
        /// <param name="feedbackGroupId">
        /// Groups feedback written together, such as one comparison in a pairwise experiment.
        /// </param>
        /// <param name="comparativeExperimentId">
        /// The ID of the comparative (pairwise) experiment this feedback was written for.
        /// </param>
        /// <param name="runId">
        /// The ID of the run the feedback is about. Omit it for feedback on a whole tracing project or a thread.
        /// </param>
        /// <param name="sessionId">
        /// Required unless the feedback is addressed by address. The ID of the tracing project (session) the feedback belongs to.
        /// </param>
        /// <param name="address">
        /// Addresses the tracing project through an Agent environment, as lrn:agents/{id}/environments/{environment}, instead of session_id. The id is 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit. The environment is local, development, staging, or production, matched case-insensitively. Never combined with session_id. The Agent and the environment must already exist; sending feedback does not create them. Self-hosted deployments need LangSmith v0.18 or later.
        /// </param>
        /// <param name="traceId">
        /// The ID of the trace that contains run_id. With session_id and start_time, it lets the server write run feedback without looking the run up.
        /// </param>
        /// <param name="startTime">
        /// The start time of run_id, as an ISO 8601 timestamp. With session_id and trace_id, it lets the server write run feedback without looking the run up.
        /// </param>
        /// <param name="feedbackThreadId">
        /// The ID of the thread the feedback is about. Requires session_id (or address) and cannot be combined with run_id.
        /// </param>
        /// <param name="extendTraceRetention">
        /// Whether writing this feedback may upgrade the trace to extended retention. Defaults to true.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="id">
        /// The ID to give the feedback. Defaults to a new random UUID.
        /// </param>
        /// <param name="feedbackSource">
        /// Where the feedback came from, as an object whose type is api, app, model, or auto_eval.
        /// </param>
        /// <param name="feedbackConfig">
        /// The scale the score is checked against. If the feedback key already has a feedback config, this must match it exactly or the request is rejected; if it has none, this becomes the key's feedback config.
        /// </param>
        /// <param name="feedbackConfigId">
        /// The ID of the feedback config this feedback was written against. It must be a feedback config for this feedback key in the same workspace, or the feedback is rejected. It doesn't change how the score is checked; feedback_config does that. If omitted, the server may record the key's enforced feedback config, or the one created for the key by this request.
        /// </param>
        /// <param name="extra">
        /// Additional metadata to store with the feedback, as a JSON object.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            string key,
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
            string? address = default,
            global::System.Guid? traceId = default,
            global::System.DateTime? startTime = default,
            string? feedbackThreadId = default,
            bool? extendTraceRetention = default,
            global::System.Guid? id = default,
            global::LangSmith.FeedbackSourceVariant12? feedbackSource = default,
            global::LangSmith.FeedbackConfig? feedbackConfig = default,
            global::System.Guid? feedbackConfigId = default,
            object? extra = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}