#nullable enable

namespace LangSmith
{
    public partial interface IFleetWebhooksClient
    {
        /// <summary>
        /// Run a fleet webhook<br/>
        /// Sends the request payload to the webhook's stored URL and returns the upstream response in a JSON envelope.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentBuilderWebhooksWebhookTestResult> RunAFleetWebhookAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a fleet webhook<br/>
        /// Sends the request payload to the webhook's stored URL and returns the upstream response in a JSON envelope.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentBuilderWebhooksWebhookTestResult> RunAFleetWebhookAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}