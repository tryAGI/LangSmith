#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggersClient
    {
        /// <summary>
        /// Get trigger<br/>
        /// Returns a single trigger by id for the calling user.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TriggersTrigger> GetTriggerAsync(
            string triggerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get trigger<br/>
        /// Returns a single trigger by id for the calling user.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TriggersTrigger>> GetTriggerAsResponseAsync(
            string triggerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}