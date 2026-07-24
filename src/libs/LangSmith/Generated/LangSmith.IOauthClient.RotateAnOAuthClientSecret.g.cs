#nullable enable

namespace LangSmith
{
    public partial interface IOauthClient
    {
        /// <summary>
        /// Rotate an OAuth client secret<br/>
        /// Generates a new client secret for a confidential client, invalidating the previous one. The new secret is shown only once.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.OauthOAuthClientCredentialsResponse> RotateAnOAuthClientSecretAsync(
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rotate an OAuth client secret<br/>
        /// Generates a new client secret for a confidential client, invalidating the previous one. The new secret is shown only once.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.OauthOAuthClientCredentialsResponse>> RotateAnOAuthClientSecretAsResponseAsync(
            string id,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}