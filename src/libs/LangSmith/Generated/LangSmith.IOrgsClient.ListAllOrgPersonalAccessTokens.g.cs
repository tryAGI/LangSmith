#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// List All Org Personal Access Tokens<br/>
        /// List every organization member's personal access tokens.
        /// </summary>
        /// <param name="workspaceIds">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>> ListAllOrgPersonalAccessTokensAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List All Org Personal Access Tokens<br/>
        /// List every organization member's personal access tokens.
        /// </summary>
        /// <param name="workspaceIds">
        /// Default Value: []
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::LangSmith.APIKeyGetResponse>>> ListAllOrgPersonalAccessTokensAsResponseAsync(
            global::System.Collections.Generic.IList<global::System.Guid>? workspaceIds = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}