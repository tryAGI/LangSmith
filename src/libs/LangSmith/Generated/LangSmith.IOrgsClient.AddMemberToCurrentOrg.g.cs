#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentOrgAsync(

            global::LangSmith.PendingIdentityCreate request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="email"></param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentOrgAsync(
            string email,
            global::System.Guid? roleId = default,
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds = default,
            global::System.Guid? workspaceRoleId = default,
            string? password = default,
            string? fullName = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}