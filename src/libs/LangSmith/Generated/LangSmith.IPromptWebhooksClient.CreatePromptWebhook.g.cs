#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Create Prompt Webhook<br/>
        /// Create a new prompt webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> CreatePromptWebhookAsync(
            global::LangSmith.PromptWebhookCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Prompt Webhook<br/>
        /// Create a new prompt webhook.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="headers"></param>
        /// <param name="includePrompts"></param>
        /// <param name="excludePrompts"></param>
        /// <param name="triggers"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PromptWebhook> CreatePromptWebhookAsync(
            string url,
            object? headers = default,
            global::System.Collections.Generic.IList<global::System.Guid>? includePrompts = default,
            global::System.Collections.Generic.IList<global::System.Guid>? excludePrompts = default,
            global::System.Collections.Generic.IList<global::LangSmith.EPromptWebhookTrigger>? triggers = default,
            global::System.Guid? id = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}