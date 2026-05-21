#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Authorize a device code<br/>
        /// Marks a device code as authorized for the authenticated user. Called by the /activate page when the user enters their user code. Requires authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> AuthorizeADeviceCodeAsync(

            global::LangSmith.CreateOauthDeviceAuthorizeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize a device code<br/>
        /// Marks a device code as authorized for the authenticated user. Called by the /activate page when the user enters their user code. Requires authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::System.Collections.Generic.Dictionary<string, string>>> AuthorizeADeviceCodeAsResponseAsync(

            global::LangSmith.CreateOauthDeviceAuthorizeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Authorize a device code<br/>
        /// Marks a device code as authorized for the authenticated user. Called by the /activate page when the user enters their user code. Requires authentication.
        /// </summary>
        /// <param name="organizationId">
        /// Organization ID; must match the authenticated org
        /// </param>
        /// <param name="workspaceId">
        /// Default workspace ID; must belong to organization and be accessible to user
        /// </param>
        /// <param name="userCode">
        /// User code displayed on the device
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, string>> AuthorizeADeviceCodeAsync(
            string organizationId,
            string userCode,
            string? workspaceId = default,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}