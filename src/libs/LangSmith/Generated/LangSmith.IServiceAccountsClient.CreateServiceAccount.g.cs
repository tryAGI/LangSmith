#nullable enable

namespace LangSmith
{
    public partial interface IServiceAccountsClient
    {
        /// <summary>
        /// Create Service Account<br/>
        /// Create a service account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ServiceAccountCreateResponse> CreateServiceAccountAsync(
            global::LangSmith.ServiceAccountCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Service Account<br/>
        /// Create a service account
        /// </summary>
        /// <param name="name"></param>
        /// <param name="workspaces"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ServiceAccountCreateResponse> CreateServiceAccountAsync(
            string name,
            global::System.Collections.Generic.IList<global::LangSmith.ServiceAccountWorkspaceAssignment>? workspaces = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}