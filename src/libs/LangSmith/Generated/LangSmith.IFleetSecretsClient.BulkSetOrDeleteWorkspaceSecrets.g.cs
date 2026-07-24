#nullable enable

namespace LangSmith
{
    public partial interface IFleetSecretsClient
    {
        /// <summary>
        /// Bulk set or delete workspace secrets<br/>
        /// Sets or deletes multiple workspace secrets in one request, mirroring the upstream SecretUpsert contract. A null value deletes the key; a non-null value sets it. Values are never returned. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task BulkSetOrDeleteWorkspaceSecretsAsync(

            global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem> request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk set or delete workspace secrets<br/>
        /// Sets or deletes multiple workspace secrets in one request, mirroring the upstream SecretUpsert contract. A null value deletes the key; a non-null value sets it. Values are never returned. Secrets are a single shared namespace per workspace. Any agent (triggered by any member) can use them, and any member whose role grants workspaces:manage-secrets (Workspace Admins by default) can overwrite or delete them. Setting an existing name replaces its value for everyone. Treat them as shared team credentials, not personal keys.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse> BulkSetOrDeleteWorkspaceSecretsAsResponseAsync(

            global::System.Collections.Generic.IList<global::LangSmith.SecretsBulkUpsertItem> request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}