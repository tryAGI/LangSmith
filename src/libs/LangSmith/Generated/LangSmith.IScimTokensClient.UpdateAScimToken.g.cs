#nullable enable

namespace LangSmith
{
    public partial interface IScimTokensClient
    {

        /// <summary>
        /// Update a SCIM token<br/>
        /// Update the description of an existing SCIM token for the current organization.
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenResponse> UpdateAScimTokenAsync(

            global::LangSmith.ScimUpdateScimTokenPayload request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a SCIM token<br/>
        /// Update the description of an existing SCIM token for the current organization.
        /// </summary>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ScimScimTokenResponse> UpdateAScimTokenAsync(
            string? description = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}