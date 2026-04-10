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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentBuilderWebhooksWebhookTestResult> RunAFleetWebhookAsync(

            object request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Run a fleet webhook<br/>
        /// Sends the request payload to the webhook's stored URL and returns the upstream response in a JSON envelope.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AgentBuilderWebhooksWebhookTestResult> RunAFleetWebhookAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}