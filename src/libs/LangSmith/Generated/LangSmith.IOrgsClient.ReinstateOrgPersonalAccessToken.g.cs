#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Reinstate Org Personal Access Token<br/>
        /// Lift a revocation, so the personal access token authenticates again.<br/>
        /// The token returns to the expiry it was created with, and one whose expiry has<br/>
        /// since passed stays expired. If the token was used while revoked, it starts<br/>
        /// working again once the rejection leaves the authentication cache. Lifting a<br/>
        /// revocation that is not there changes nothing. Callers may always administer<br/>
        /// their own tokens; organization admins may administer any member's.
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task ReinstateOrgPersonalAccessTokenAsync(
            global::System.Guid patId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Reinstate Org Personal Access Token<br/>
        /// Lift a revocation, so the personal access token authenticates again.<br/>
        /// The token returns to the expiry it was created with, and one whose expiry has<br/>
        /// since passed stays expired. If the token was used while revoked, it starts<br/>
        /// working again once the rejection leaves the authentication cache. Lifting a<br/>
        /// revocation that is not there changes nothing. Callers may always administer<br/>
        /// their own tokens; organization admins may administer any member's.
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> ReinstateOrgPersonalAccessTokenAsResponseAsync(
            global::System.Guid patId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}