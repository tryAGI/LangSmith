#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Stop a sandbox<br/>
        /// Stop a ready Firecracker sandbox. This endpoint is not idempotent; the rootfs is preserved on JuiceFS for later restart.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task StopASandboxAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}