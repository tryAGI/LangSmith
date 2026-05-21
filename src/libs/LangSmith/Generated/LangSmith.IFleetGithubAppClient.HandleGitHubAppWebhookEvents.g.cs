#nullable enable

namespace LangSmith
{
    public partial interface IFleetGithubAppClient
    {
        /// <summary>
        /// Handle GitHub App webhook events<br/>
        /// Process GitHub App webhooks (installation lifecycle, installation_repositories). GitHub may deliver the same event more than once; handling re-applies the current repository-selection state and is safe to repeat.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task HandleGitHubAppWebhookEventsAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Handle GitHub App webhook events<br/>
        /// Process GitHub App webhooks (installation lifecycle, installation_repositories). GitHub may deliver the same event more than once; handling re-applies the current repository-selection state and is safe to repeat.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> HandleGitHubAppWebhookEventsAsResponseAsync(
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}