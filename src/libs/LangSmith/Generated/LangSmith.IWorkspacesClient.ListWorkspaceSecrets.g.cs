#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// List workspace secrets<br/>
        /// List the current workspace's secret keys in ascending key order. Secret values are never returned. Set include_configs to include allowed hosts and header configuration. Pass next_cursor as cursor to retrieve the next page, keeping include_configs unchanged. Pagination reflects the current secrets on each request, rather than a snapshot.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="includeConfigs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.WorkspacesListSecretsResponse> ListWorkspaceSecretsAsync(
            int? pageSize = default,
            string? cursor = default,
            bool? includeConfigs = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace secrets<br/>
        /// List the current workspace's secret keys in ascending key order. Secret values are never returned. Set include_configs to include allowed hosts and header configuration. Pass next_cursor as cursor to retrieve the next page, keeping include_configs unchanged. Pagination reflects the current secrets on each request, rather than a snapshot.
        /// </summary>
        /// <param name="pageSize">
        /// Default Value: 20
        /// </param>
        /// <param name="cursor"></param>
        /// <param name="includeConfigs">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.WorkspacesListSecretsResponse>> ListWorkspaceSecretsAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            bool? includeConfigs = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}