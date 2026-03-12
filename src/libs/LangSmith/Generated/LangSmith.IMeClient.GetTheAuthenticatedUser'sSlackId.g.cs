#nullable enable

namespace LangSmith
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Get the authenticated user's Slack ID<br/>
        /// Returns the Slack user ID associated with the authenticated user, or null if not set.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetTheAuthenticatedUser'sSlackIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}