#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggersClient
    {
        /// <summary>
        /// Create trigger<br/>
        /// Creates a trigger for an agent and returns the created trigger instance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTrigger> CreateTriggerAsync(

            global::LangSmith.TriggersCreateTriggerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trigger<br/>
        /// Creates a trigger for an agent and returns the created trigger instance.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TriggersTrigger>> CreateTriggerAsResponseAsync(

            global::LangSmith.TriggersCreateTriggerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create trigger<br/>
        /// Creates a trigger for an agent and returns the created trigger instance.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="config"></param>
        /// <param name="name"></param>
        /// <param name="registrationId"></param>
        /// <param name="status"></param>
        /// <param name="templateId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTrigger> CreateTriggerAsync(
            string? agentId = default,
            object? config = default,
            string? name = default,
            string? registrationId = default,
            string? status = default,
            string? templateId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}