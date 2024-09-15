#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentOrgAsync(
            global::LangSmith.PendingIdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Add Member To Current Org
        /// </summary>
        /// <param name="email"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentOrgAsync(
            string email,
            bool readOnly = false,
            global::LangSmith.AnyOf<global::System.Guid?, object>? roleId = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::System.Guid>, object>? workspaceIds = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? workspaceRoleId = default,
            global::LangSmith.AnyOf<string, object>? password = default,
            global::LangSmith.AnyOf<string, object>? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}