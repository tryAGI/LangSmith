#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Get Current User Login Methods<br/>
        /// Get login methods for the current user.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ProviderUserSlim>> GetCurrentUserLoginMethodsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}