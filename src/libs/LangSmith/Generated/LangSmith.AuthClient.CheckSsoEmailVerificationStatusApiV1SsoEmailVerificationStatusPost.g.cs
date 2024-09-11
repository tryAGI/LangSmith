
#nullable enable

namespace LangSmith
{
    public partial class AuthClient
    {
        partial void PrepareCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.SSOEmailVerificationStatusRequest request);
        partial void PrepareCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.SSOEmailVerificationStatusRequest request);
        partial void ProcessCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Check Sso Email Verification Status<br/>
        /// Retrieve the email verification status of an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SSOEmailVerificationStatusResponse> CheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostAsync(
            global::LangSmith.SSOEmailVerificationStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/sso/email-verification/status", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.SSOEmailVerificationStatusRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.SSOEmailVerificationStatusResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Check Sso Email Verification Status<br/>
        /// Retrieve the email verification status of an SSO user.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SSOEmailVerificationStatusResponse> CheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostAsync(
            string email,
            string samlProviderId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.SSOEmailVerificationStatusRequest
            {
                Email = email,
                SamlProviderId = samlProviderId,
            };

            return await CheckSsoEmailVerificationStatusApiV1SsoEmailVerificationStatusPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}