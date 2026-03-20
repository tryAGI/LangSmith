#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Delete Org Personal Access Token
        /// </summary>
        /// <param name="patId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyGetResponse> DeleteOrgPersonalAccessTokenAsync(
            global::System.Guid patId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}