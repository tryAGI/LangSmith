#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {

        /// <summary>
        /// Get public auth info<br/>
        /// Returns public authentication information for the current workspace-level session.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AuthnPublicAuthInfo> GetPublicAuthInfoAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}