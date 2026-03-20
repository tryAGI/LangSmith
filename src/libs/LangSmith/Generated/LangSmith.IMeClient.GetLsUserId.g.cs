#nullable enable

namespace LangSmith
{
    public partial interface IMeClient
    {
        /// <summary>
        /// Get Ls User Id<br/>
        /// Get the LangSmith user ID for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLsUserIdAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}