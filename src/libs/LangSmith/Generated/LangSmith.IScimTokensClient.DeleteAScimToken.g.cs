#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {
        /// <summary>
        /// Delete a SCIM token<br/>
        /// Delete a SCIM bearer token from the current organization.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAScimTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}