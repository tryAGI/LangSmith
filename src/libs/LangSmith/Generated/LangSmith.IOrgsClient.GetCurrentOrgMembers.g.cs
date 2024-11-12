#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current Org Members
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrganizationMembers> GetCurrentOrgMembersAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}