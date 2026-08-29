#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// Roll an issues agent webhook signing secret<br/>
        /// Replaces the signing secret for the given generic URL issues agent webhook. Slack<br/>
        /// and Jira destinations do not have signing secrets. The new secret is returned once in this<br/>
        /// response; future deliveries use it immediately. URL and header values are redacted;<br/>
        /// only a safe URL display and header names are returned.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook> RollAnIssuesAgentWebhookSigningSecretAsync(
            string sessionId,
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Roll an issues agent webhook signing secret<br/>
        /// Replaces the signing secret for the given generic URL issues agent webhook. Slack<br/>
        /// and Jira destinations do not have signing secrets. The new secret is returned once in this<br/>
        /// response; future deliveries use it immediately. URL and header values are redacted;<br/>
        /// only a safe URL display and header names are returned.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TracerSessionIssuesAgentWebhooksIssuesAgentWebhook>> RollAnIssuesAgentWebhookSigningSecretAsResponseAsync(
            string sessionId,
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}