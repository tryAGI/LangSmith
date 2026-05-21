#nullable enable

namespace LangSmith
{
    public partial interface IFleetTriggersClient
    {
        /// <summary>
        /// Delete trigger<br/>
        /// Deletes a trigger by id for the calling user. The operation is idempotent - deleting a trigger that does not exist (or that belongs to another user) still returns 204.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteTriggerAsync(
            string triggerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete trigger<br/>
        /// Deletes a trigger by id for the calling user. The operation is idempotent - deleting a trigger that does not exist (or that belongs to another user) still returns 204.
        /// </summary>
        /// <param name="triggerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteTriggerAsResponseAsync(
            string triggerId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}