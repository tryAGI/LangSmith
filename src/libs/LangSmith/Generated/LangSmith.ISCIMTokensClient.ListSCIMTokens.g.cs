#nullable enable

namespace LangSmith
{
    public partial interface ISCIMTokensClient
    {
        /// <summary>
        /// List SCIM tokens<br/>
        /// List all SCIM bearer tokens for the current organization. The full token values are not returned.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ScimScimTokenResponse>> ListSCIMTokensAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}