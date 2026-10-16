#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Update Prompt Webhook<br/>
        /// Update a specific prompt webhook.<br/>
        /// Omitted fields keep their current values; list fields and headers that are<br/>
        /// set replace the stored values.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> UpdatePromptWebhookAsync(
            global::System.Guid webhookId,

            global::LangSmith.PromptWebhookUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Prompt Webhook<br/>
        /// Update a specific prompt webhook.<br/>
        /// Omitted fields keep their current values; list fields and headers that are<br/>
        /// set replace the stored values.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.PromptWebhook>> UpdatePromptWebhookAsResponseAsync(
            global::System.Guid webhookId,

            global::LangSmith.PromptWebhookUpdate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Prompt Webhook<br/>
        /// Update a specific prompt webhook.<br/>
        /// Omitted fields keep their current values; list fields and headers that are<br/>
        /// set replace the stored values.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="includePrompts">
        /// IDs of the prompts whose events fire the webhook, replacing the current list. Omit to keep it.
        /// </param>
        /// <param name="excludePrompts">
        /// IDs of prompts whose events never fire the webhook, replacing the current list. Omit to keep it.
        /// </param>
        /// <param name="url">
        /// URL that receives the POST requests. Omit to keep the current URL.
        /// </param>
        /// <param name="headers">
        /// HTTP headers sent with each request, replacing all current headers. Omit to keep them. Masked values (********) from a read are rejected.
        /// </param>
        /// <param name="triggers">
        /// Events that fire the webhook (commit, tag:create, tag:update), replacing the current list. Omit to keep it.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> UpdatePromptWebhookAsync(
            global::System.Guid webhookId,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts = default,
            string? url = default,
            object? headers = default,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}