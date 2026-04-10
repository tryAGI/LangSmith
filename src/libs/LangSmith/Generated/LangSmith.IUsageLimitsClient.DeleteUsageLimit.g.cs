#nullable enable

namespace LangSmith
{
    public partial interface IUsageLimitsClient
    {
        /// <summary>
        /// Delete Usage Limit<br/>
        /// Delete a specific usage limit.
        /// </summary>
        /// <param name="usageLimitId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteUsageLimitAsync(
            global::System.Guid usageLimitId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}