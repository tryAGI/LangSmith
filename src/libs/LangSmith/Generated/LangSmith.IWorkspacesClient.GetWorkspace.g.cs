#nullable enable

namespace LangSmith
{
    public partial interface IWorkspacesClient
    {
        /// <summary>
        /// Get Workspace<br/>
        /// Get a single workspace by ID, scoped to the current org and identity.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="dataPlaneId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.TenantForUser> GetWorkspaceAsync(
            global::System.Guid workspaceId,
            bool? includeDeleted = default,
            global::System.Guid? dataPlaneId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Workspace<br/>
        /// Get a single workspace by ID, scoped to the current org and identity.
        /// </summary>
        /// <param name="workspaceId"></param>
        /// <param name="includeDeleted">
        /// Default Value: false
        /// </param>
        /// <param name="dataPlaneId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.TenantForUser>> GetWorkspaceAsResponseAsync(
            global::System.Guid workspaceId,
            bool? includeDeleted = default,
            global::System.Guid? dataPlaneId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}