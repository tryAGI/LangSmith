#nullable enable

namespace LangSmith
{
    public partial interface IMeClient
    {

        /// <summary>
        /// Get the authenticated user's provider user ID<br/>
        /// Returns the provider user ID associated with the authenticated user for a given provider type, or null if not set. Scoped to the current tenant.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTheAuthenticatedUsersProviderUserIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}