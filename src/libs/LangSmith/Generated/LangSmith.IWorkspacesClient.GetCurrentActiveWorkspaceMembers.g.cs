#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Current Active Workspace Members
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="emails">
        /// Default Value: []
        /// </param>
        /// <param name="q">
        /// Search query for email
        /// </param>
        /// <param name="sortByDesc">
        /// Sort in descending order<br/>
        /// Default Value: true
        /// </param>
        /// <param name="lsUserIds">
        /// Default Value: []
        /// </param>
        /// <param name="userIds"></param>
        /// <param name="isDisabled"></param>
        /// <param name="sortBy">
        /// Field to sort by<br/>
        /// Default Value: created_at
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.MemberIdentity>> GetCurrentActiveWorkspaceMembersAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            string? q = default,
            bool? sortByDesc = default,
            global::System.Collections.Generic.IList<global::System.Guid>? lsUserIds = default,
            global::System.Collections.Generic.IList<global::System.Guid>? userIds = default,
            bool? isDisabled = default,
            global::LangSmith.MemberSortField? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}