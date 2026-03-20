#nullable enable

namespace LangSmith
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// List sandbox claims<br/>
        /// List sandbox claims for the authenticated tenant, with optional name filtering and pagination.
        /// </summary>
        /// <param name="limit">
        /// Default Value: 50
        /// </param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="nameContains"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SandboxesClaimListResponse> ListSandboxClaimsAsync(
            int? limit = default,
            int? offset = default,
            string? nameContains = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}