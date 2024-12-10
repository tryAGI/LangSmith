#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Pending Workspace Members
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="emails"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.PendingIdentity>> GetCurrentPendingWorkspaceMembersAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}