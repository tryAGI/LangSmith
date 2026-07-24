#nullable enable

namespace LangSmith
{
    public partial interface IFleetSecretsClient
    {
        /// <summary>
        /// List workspace secret names<br/>
        /// Lists the names of secrets configured for the workspace. Use this to check which model API keys (see a model's required_secrets) are already set. Secret values are never returned. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.SecretsListResponse> ListWorkspaceSecretNamesAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List workspace secret names<br/>
        /// Lists the names of secrets configured for the workspace. Use this to check which model API keys (see a model's required_secrets) are already set. Secret values are never returned. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="pageSize"></param>
        /// <param name="cursor"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.SecretsListResponse>> ListWorkspaceSecretNamesAsResponseAsync(
            int? pageSize = default,
            string? cursor = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}