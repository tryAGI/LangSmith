#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {

        /// <summary>
        /// Get a SCIM token<br/>
        /// Retrieve a specific SCIM token by ID for the current organization. The full token value is not returned.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenResponse> GetAScimTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}