#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceAsync(
            global::LangSmith.IdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceAsync(
            global::System.Guid userId,
            bool? readOnly = default,
            global::System.Guid? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}