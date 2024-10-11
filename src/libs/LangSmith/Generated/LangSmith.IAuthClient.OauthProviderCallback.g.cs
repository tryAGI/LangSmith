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
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<object> OauthProviderCallbackAsync(
            global::LangSmith.OAuthProvider provider = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}