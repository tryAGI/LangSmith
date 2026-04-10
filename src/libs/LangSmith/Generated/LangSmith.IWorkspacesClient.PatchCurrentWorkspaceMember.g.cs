#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,

            global::LangSmith.IdentityPatch request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="roleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> PatchCurrentWorkspaceMemberAsync(
            global::System.Guid identityId,
            global::System.Guid roleId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}