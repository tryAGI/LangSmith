#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Delete Workspace<br/>
        /// Delete a workspace and its data.<br/>
        /// Only the workspace the request is scoped to (the X-Tenant-Id header, or the API key's workspace)<br/>
        /// can be deleted; any other ID returns 403. Requires the workspace delete permission.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteWorkspaceAsync(
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Delete Workspace<br/>
        /// Delete a workspace and its data.<br/>
        /// Only the workspace the request is scoped to (the X-Tenant-Id header, or the API key's workspace)<br/>
        /// can be deleted; any other ID returns 403. Requires the workspace delete permission.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<string>> DeleteWorkspaceAsResponseAsync(
            global::System.Guid workspaceId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}