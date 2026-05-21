#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Request OAuth2 device authorization<br/>
        /// Issues a device code and user code for the device authorization flow per RFC 8628.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthDeviceCodeResponse> RequestOAuth2DeviceAuthorizationAsync(

            global::LangSmith.CreateOauthDeviceCodeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request OAuth2 device authorization<br/>
        /// Issues a device code and user code for the device authorization flow per RFC 8628.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthDeviceCodeResponse>> RequestOAuth2DeviceAuthorizationAsResponseAsync(

            global::LangSmith.CreateOauthDeviceCodeRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Request OAuth2 device authorization<br/>
        /// Issues a device code and user code for the device authorization flow per RFC 8628.
        /// </summary>
        /// <param name="clientId">
        /// OAuth2 client ID
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthDeviceCodeResponse> RequestOAuth2DeviceAuthorizationAsync(
            string clientId,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}