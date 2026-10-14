#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Put Current Workspace Secret<br/>
        /// Create or update a workspace secret and the hosts it may be sent to.<br/>
        /// Omit `value` to keep the current one; it is required to create a secret.<br/>
        /// `configs` replaces the secret's hosts; omitted or empty restores the<br/>
        /// built-in defaults for known provider keys. The value is never returned.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.WorkspaceSecret> PutCurrentWorkspaceSecretAsync(
            string key,

            global::LangSmith.WorkspaceSecretUpsert request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Current Workspace Secret<br/>
        /// Create or update a workspace secret and the hosts it may be sent to.<br/>
        /// Omit `value` to keep the current one; it is required to create a secret.<br/>
        /// `configs` replaces the secret's hosts; omitted or empty restores the<br/>
        /// built-in defaults for known provider keys. The value is never returned.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.WorkspaceSecret>> PutCurrentWorkspaceSecretAsResponseAsync(
            string key,

            global::LangSmith.WorkspaceSecretUpsert request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Put Current Workspace Secret<br/>
        /// Create or update a workspace secret and the hosts it may be sent to.<br/>
        /// Omit `value` to keep the current one; it is required to create a secret.<br/>
        /// `configs` replaces the secret's hosts; omitted or empty restores the<br/>
        /// built-in defaults for known provider keys. The value is never returned.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value">
        /// Secret value. Required to create a secret; omit to keep the current value.
        /// </param>
        /// <param name="configs">
        /// Full replacement of the allowed hosts. Omitted or empty removes custom hosts so the built-in defaults, if any, apply.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.WorkspaceSecret> PutCurrentWorkspaceSecretAsync(
            string key,
            string? value = default,
            global::System.Collections.Generic.IList<global::LangSmith.SecretConfigInput>? configs = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}