#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Pending Workspace Invite
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.DeletePendingWorkspaceInviteApiV1WorkspacesPendingIdDeleteResponse> DeletePendingWorkspaceInviteAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}