#nullable enable

namespace LangSmith
{
    public partial interface IOrgsClient
    {
        /// <summary>
        /// Update Org Service Key<br/>
        /// Update an API key's role(s) in place without rotating the key.<br/>
        /// Organization Operators cannot assign the Organization Admin role or change<br/>
        /// a key that already holds it, and no key can change its own roles. Applies<br/>
        /// to both org-scoped and workspace-scoped keys.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyGetResponse> UpdateOrgServiceKeyAsync(
            global::System.Guid apiKeyId,

            global::LangSmith.APIKeyUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Org Service Key<br/>
        /// Update an API key's role(s) in place without rotating the key.<br/>
        /// Organization Operators cannot assign the Organization Admin role or change<br/>
        /// a key that already holds it, and no key can change its own roles. Applies<br/>
        /// to both org-scoped and workspace-scoped keys.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.APIKeyGetResponse>> UpdateOrgServiceKeyAsResponseAsync(
            global::System.Guid apiKeyId,

            global::LangSmith.APIKeyUpdateRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Org Service Key<br/>
        /// Update an API key's role(s) in place without rotating the key.<br/>
        /// Organization Operators cannot assign the Organization Admin role or change<br/>
        /// a key that already holds it, and no key can change its own roles. Applies<br/>
        /// to both org-scoped and workspace-scoped keys.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="roleId"></param>
        /// <param name="orgRoleId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.APIKeyGetResponse> UpdateOrgServiceKeyAsync(
            global::System.Guid apiKeyId,
            global::System.Guid? roleId = default,
            global::System.Guid? orgRoleId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}