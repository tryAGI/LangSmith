#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Delete Prompt Webhook<br/>
        /// Delete a specific prompt webhook.
        /// </summary>
        /// <param name="webhookId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeletePromptWebhookAsync(
            global::System.Guid webhookId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}