#nullable enable

namespace LangSmith
{
    public partial interface ISCIMTokensClient
    {
        /// <summary>
        /// Delete a SCIM token<br/>
        /// Delete a SCIM bearer token from the current organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteASCIMTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}