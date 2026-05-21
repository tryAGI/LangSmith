#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggersClient
    {
        /// <summary>
        /// Update trigger<br/>
        /// Updates a trigger by id for the calling user. agent_id is not mutable.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTrigger> UpdateTriggerAsync(
            string triggerId,

            global::LangSmith.TriggersUpdateTriggerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update trigger<br/>
        /// Updates a trigger by id for the calling user. agent_id is not mutable.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TriggersTrigger>> UpdateTriggerAsResponseAsync(
            string triggerId,

            global::LangSmith.TriggersUpdateTriggerRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update trigger<br/>
        /// Updates a trigger by id for the calling user. agent_id is not mutable.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="config"></param>
        /// <param name="name"></param>
        /// <param name="status"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTrigger> UpdateTriggerAsync(
            string triggerId,
            object? config = default,
            string? name = default,
            string? status = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}