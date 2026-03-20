#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {

        /// <summary>
        /// Get sandbox resource usage<br/>
        /// Get current sandbox resource usage and quota limits for the workspace
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesUsageResponse> GetSandboxResourceUsageAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}