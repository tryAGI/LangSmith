#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Workspace Usage Limits Info
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TenantUsageLimitInfo> GetCurrentWorkspaceUsageLimitsInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}