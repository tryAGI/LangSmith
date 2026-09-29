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
        /// required unless the feedback is addressed by `agent_id` and<br/>
        /// `agent_environment`, which name that project through an Agent environment<br/>
        /// that already exists.
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
        /// required unless the feedback is addressed by `agent_id` and<br/>
        /// `agent_environment`, which name that project through an Agent environment<br/>
        /// that already exists.
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
        /// required unless the feedback is addressed by `agent_id` and<br/>
        /// `agent_environment`, which name that project through an Agent environment<br/>
        /// that already exists.
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
        /// <param name="sessionId">
        /// Required unless the feedback is addressed by agent_id and agent_environment. The ID of the tracing project (session) the feedback belongs to.
        /// </param>
        /// <param name="agentId">
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent's id, not a UUID: 1 to 63 lowercase ASCII letters, digits, or hyphens, starting with a letter and ending with a letter or digit (e.g. support-agent). Addresses the tracing project through an Agent instead of session_id. Sent together with agent_environment, and never alongside session_id. The Agent and the environment must already exist; sending feedback does not create them.
        /// </param>
        /// <param name="agentEnvironment">
        /// Experimental. Only supported in workspaces where Agent addressing is enabled; other workspaces get a 403. The Agent environment whose tracing project the feedback belongs to. Matched case-insensitively. Sent together with agent_id.
        /// </param>
        /// <param name="traceId"></param>
        /// <param name="startTime"></param>
        /// <param name="feedbackThreadId"></param>
        /// <param name="extendTraceRetention">
        /// Default Value: true
        /// </param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="extra"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackAsync(
            string key,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            global::LangSmith.AnyOf<double?, int?, bool?, object>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object, object>? value = default,
            string? comment = default,
            global::LangSmith.AnyOf<object, string, object>? correction = default,
            global::System.Guid? feedbackGroupId = default,
            global::System.Guid? comparativeExperimentId = default,
            global::System.Guid? runId = default,
            global::System.Guid? sessionId = default,
            string? agentId = default,
            global::LangSmith.FeedbackCreateSchemaAgentEnvironment? agentEnvironment = default,
            global::System.Guid? traceId = default,
            global::System.DateTime? startTime = default,
            string? feedbackThreadId = default,
            bool? extendTraceRetention = default,
            global::System.Guid? id = default,
            global::LangSmith.FeedbackSourceVariant12? feedbackSource = default,
            global::LangSmith.FeedbackConfig? feedbackConfig = default,
            object? extra = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}