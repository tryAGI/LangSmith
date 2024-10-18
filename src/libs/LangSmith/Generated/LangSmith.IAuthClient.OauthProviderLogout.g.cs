#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Oauth Provider Logout
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProviderLogoutAsync(
            global::LangSmith.OAuthProvider provider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}