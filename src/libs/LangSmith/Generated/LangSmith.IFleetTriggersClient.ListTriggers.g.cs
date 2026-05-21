#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggersClient
    {
        /// <summary>
        /// List triggers<br/>
        /// Lists triggers for the calling user (paginated). Filter by agent_id and/or template_id.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="templateId"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTriggerListResponse> ListTriggersAsync(
            string? agentId = default,
            string? templateId = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List triggers<br/>
        /// Lists triggers for the calling user (paginated). Filter by agent_id and/or template_id.
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="templateId"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TriggersTriggerListResponse>> ListTriggersAsResponseAsync(
            string? agentId = default,
            string? templateId = default,
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}