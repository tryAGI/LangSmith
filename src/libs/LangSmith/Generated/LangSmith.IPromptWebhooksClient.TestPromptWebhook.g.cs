#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Test Prompt Webhook<br/>
        /// Test a specific prompt webhook.<br/>
        /// Sends the sample payload to the webhook configuration in the request body<br/>
        /// without saving it, but only if the webhook's triggers include the payload's<br/>
        /// event and its prompt filters match the payload's prompt. Otherwise nothing<br/>
        /// is sent. Fails if the destination does not accept the payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> TestPromptWebhookAsync(

            global::LangSmith.PromptWebhookTest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Prompt Webhook<br/>
        /// Test a specific prompt webhook.<br/>
        /// Sends the sample payload to the webhook configuration in the request body<br/>
        /// without saving it, but only if the webhook's triggers include the payload's<br/>
        /// event and its prompt filters match the payload's prompt. Otherwise nothing<br/>
        /// is sent. Fails if the destination does not accept the payload.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> TestPromptWebhookAsResponseAsync(

            global::LangSmith.PromptWebhookTest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Test Prompt Webhook<br/>
        /// Test a specific prompt webhook.<br/>
        /// Sends the sample payload to the webhook configuration in the request body<br/>
        /// without saving it, but only if the webhook's triggers include the payload's<br/>
        /// event and its prompt filters match the payload's prompt. Otherwise nothing<br/>
        /// is sent. Fails if the destination does not accept the payload.
        /// </summary>
        /// <param name="webhook">
        /// Base schema for prompt webhooks.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> TestPromptWebhookAsync(
            global::LangSmith.PromptWebhookBase webhook,
            global::LangSmith.PromptWebhookPayload payload,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}