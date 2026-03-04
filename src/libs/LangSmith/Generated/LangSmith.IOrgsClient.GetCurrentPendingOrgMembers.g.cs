#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current Pending Org Members
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="emails"></param>
        /// <param name="q">
        /// Search query for email
        /// </param>
        /// <param name="sortByDesc">
        /// Sort in descending order<br/>
        /// Default Value: true
        /// </param>
        /// <param name="sortBy">
        /// Sort fields for members list endpoints.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.OrgPendingIdentity>> GetCurrentPendingOrgMembersAsync(
            int? limit = default,
            int? offset = default,
            global::System.Collections.Generic.IList<string>? emails = default,
            string? q = default,
            bool? sortByDesc = default,
            global::LangSmith.MemberSortField? sortBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}