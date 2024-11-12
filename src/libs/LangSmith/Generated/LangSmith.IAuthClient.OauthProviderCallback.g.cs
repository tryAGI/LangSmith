#nullable enable

namespace LangSmith
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Oauth Provider Callback
        /// </summary>
        /// <param name="provider"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OauthProviderCallbackAsync(
            global::LangSmith.OAuthProvider provider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}