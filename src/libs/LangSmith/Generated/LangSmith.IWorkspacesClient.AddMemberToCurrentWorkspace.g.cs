#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceAsync(

            global::LangSmith.IdentityCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Member To Current Workspace<br/>
        /// Add an existing organization member to the current workspace.
        /// </summary>
        /// <param name="orgIdentityId"></param>
        /// <param name="lsUserId"></param>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.Identity> AddMemberToCurrentWorkspaceAsync(
            global::System.Guid? orgIdentityId = default,
            global::System.Guid? lsUserId = default,
            global::System.Guid? roleId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}