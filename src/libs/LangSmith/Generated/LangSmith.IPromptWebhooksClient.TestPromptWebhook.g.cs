#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// Test Prompt Webhook<br/>
        /// Test a specific prompt webhook.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> TestPromptWebhookAsync(
            global::LangSmith.PromptWebhookTest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Test Prompt Webhook<br/>
        /// Test a specific prompt webhook.
        /// </summary>
        /// <param name="webhook">
        /// Base schema for prompt webhooks.
        /// </param>
        /// <param name="payload"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> TestPromptWebhookAsync(
            global::LangSmith.PromptWebhookBase webhook,
            global::LangSmith.PromptWebhookPayload payload,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}