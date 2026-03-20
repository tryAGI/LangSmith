#nullable enable

namespace LangSmith
{
    public partial interface IOrganizationsClient
    {

        /// <summary>
        /// Get current organization info<br/>
        /// Returns organization info for the authenticated user's current organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OrgsOrganizationInfo> GetCurrentOrganizationInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}