#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Start a sandbox<br/>
        /// Start a stopped or failed Firecracker sandbox. This endpoint is not idempotent; it returns 202 immediately, then you can poll status for readiness.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimResponse> StartASandboxAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}