#nullable enable

namespace LangSmith
{
    public partial interface IFleetSecretsClient
    {
        /// <summary>
        /// Delete a workspace secret<br/>
        /// Removes a single workspace secret by name. Succeeds whether or not the secret currently exists. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAWorkspaceSecretAsync(
            string name,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete a workspace secret<br/>
        /// Removes a single workspace secret by name. Succeeds whether or not the secret currently exists. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> DeleteAWorkspaceSecretAsResponseAsync(
            string name,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}