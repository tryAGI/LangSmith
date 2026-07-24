#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Patch Current Workspace Pending Member<br/>
        /// Update the role on a pending workspace member invite.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> PatchCurrentWorkspacePendingMemberAsync(
            global::System.Guid identityId,

            global::LangSmith.PendingIdentityPatch request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Current Workspace Pending Member<br/>
        /// Update the role on a pending workspace member invite.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.PendingIdentity>> PatchCurrentWorkspacePendingMemberAsResponseAsync(
            global::System.Guid identityId,

            global::LangSmith.PendingIdentityPatch request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Current Workspace Pending Member<br/>
        /// Update the role on a pending workspace member invite.
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="roleId"></param>
        /// <param name="roleName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> PatchCurrentWorkspacePendingMemberAsync(
            global::System.Guid identityId,
            global::System.Guid? roleId = default,
            string? roleName = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}