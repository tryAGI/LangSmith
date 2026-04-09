#nullable enable

namespace LangSmith
{
    public partial interface IFleetIntegrationsClient
    {
        /// <summary>
        /// List all integrations<br/>
        /// Returns a paginated list of integrations available in the workspace.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.IntegrationsListResponse> ListAllIntegrationsAsync(
            string? type = default,
            int? pageSize = default,
            string? cursor = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}