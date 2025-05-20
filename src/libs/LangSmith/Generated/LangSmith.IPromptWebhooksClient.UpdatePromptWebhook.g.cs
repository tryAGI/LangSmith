#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Update Prompt Webhook<br/>
        /// Update a specific prompt webhook.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> UpdatePromptWebhookAsync(
            global::System.Guid webhookId,
            global::LangSmith.PromptWebhookUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Prompt Webhook<br/>
        /// Update a specific prompt webhook.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="includePrompts"></param>
        /// <param name="excludePrompts"></param>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="triggers"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> UpdatePromptWebhookAsync(
            global::System.Guid webhookId,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts = default,
            string? url = default,
            object? headers = default,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}