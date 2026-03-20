#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox claim status<br/>
        /// Retrieve the lightweight status of a sandbox claim for polling.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimStatusResponse> GetSandboxClaimStatusAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}