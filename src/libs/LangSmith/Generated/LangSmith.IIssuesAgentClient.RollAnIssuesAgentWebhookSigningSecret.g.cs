#nullable enable

namespace LangSmith
{
    public partial interface IIssuesAgentClient
    {
        /// <summary>
        /// Roll an issues agent webhook signing secret<br/>
        /// Replaces the signing secret for the given issues agent webhook and returns the<br/>
        /// updated webhook. Future deliveries are signed with the new secret immediately.
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
        /// Replaces the signing secret for the given issues agent webhook and returns the<br/>
        /// updated webhook. Future deliveries are signed with the new secret immediately.
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