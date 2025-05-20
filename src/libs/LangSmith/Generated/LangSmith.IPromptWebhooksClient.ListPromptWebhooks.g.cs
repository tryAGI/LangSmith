#nullable enable

namespace LangSmith
{
    public partial interface IPromptWebhooksClient
    {
        /// <summary>
        /// List Prompt Webhooks<br/>
        /// List all prompt webhooks for the current tenant.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PromptWebhook>> ListPromptWebhooksAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}