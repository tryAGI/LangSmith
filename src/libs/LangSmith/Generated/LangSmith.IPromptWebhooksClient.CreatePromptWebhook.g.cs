#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Create Prompt Webhook<br/>
        /// Create a new prompt webhook.<br/>
        /// LangSmith sends a POST request to the webhook URL for each event listed in<br/>
        /// triggers on the prompts it matches. A workspace can have one prompt webhook<br/>
        /// unless its limit was raised; creating one past the limit returns 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> CreatePromptWebhookAsync(

            global::LangSmith.PromptWebhookCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Prompt Webhook<br/>
        /// Create a new prompt webhook.<br/>
        /// LangSmith sends a POST request to the webhook URL for each event listed in<br/>
        /// triggers on the prompts it matches. A workspace can have one prompt webhook<br/>
        /// unless its limit was raised; creating one past the limit returns 400.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.PromptWebhook>> CreatePromptWebhookAsResponseAsync(

            global::LangSmith.PromptWebhookCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Prompt Webhook<br/>
        /// Create a new prompt webhook.<br/>
        /// LangSmith sends a POST request to the webhook URL for each event listed in<br/>
        /// triggers on the prompts it matches. A workspace can have one prompt webhook<br/>
        /// unless its limit was raised; creating one past the limit returns 400.
        /// </summary>
        /// <param name="url">
        /// URL that receives a POST request with the prompt event payload.
        /// </param>
        /// <param name="headers">
        /// HTTP headers sent with each request, for example an Authorization header. Values are stored encrypted and are masked in responses to callers who cannot update prompts.
        /// </param>
        /// <param name="includePrompts">
        /// IDs of the prompts whose events fire the webhook. When empty, events from every prompt in the workspace fire it.
        /// </param>
        /// <param name="excludePrompts">
        /// IDs of prompts whose events never fire the webhook.
        /// </param>
        /// <param name="triggers">
        /// Events that fire the webhook: commit (a new prompt commit), tag:create, and tag:update. A webhook with no triggers never fires.
        /// </param>
        /// <param name="id">
        /// ID to assign to the webhook. Generated when omitted.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> CreatePromptWebhookAsync(
            string url,
            object? headers = default,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts = default,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers = default,
            global::System.Guid? id = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}