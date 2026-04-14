#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List org members with workspace roles<br/>
        /// Returns a paginated list of org members (active and pending) enriched with workspace memberships.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="activeIs"></param>
        /// <param name="pendingIs"></param>
        /// <param name="nameLike"></param>
        /// <param name="emailLike"></param>
        /// <param name="workspaceNameLike"></param>
        /// <param name="organizationRoleLike"></param>
        /// <param name="workspaceRoleLike"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>> ListOrgMembersWithWorkspaceRolesAsync(
            int? limit = default,
            int? offset = default,
            bool? activeIs = default,
            bool? pendingIs = default,
            byte[]? nameLike = default,
            byte[]? emailLike = default,
            byte[]? workspaceNameLike = default,
            byte[]? organizationRoleLike = default,
            byte[]? workspaceRoleLike = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List org members with workspace roles<br/>
        /// Returns a paginated list of org members (active and pending) enriched with workspace memberships.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="activeIs"></param>
        /// <param name="pendingIs"></param>
        /// <param name="nameLike"></param>
        /// <param name="emailLike"></param>
        /// <param name="workspaceNameLike"></param>
        /// <param name="organizationRoleLike"></param>
        /// <param name="workspaceRoleLike"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.OrgsOrgMemberEnriched>>> ListOrgMembersWithWorkspaceRolesAsResponseAsync(
            int? limit = default,
            int? offset = default,
            bool? activeIs = default,
            bool? pendingIs = default,
            byte[]? nameLike = default,
            byte[]? emailLike = default,
            byte[]? workspaceNameLike = default,
            byte[]? organizationRoleLike = default,
            byte[]? workspaceRoleLike = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}