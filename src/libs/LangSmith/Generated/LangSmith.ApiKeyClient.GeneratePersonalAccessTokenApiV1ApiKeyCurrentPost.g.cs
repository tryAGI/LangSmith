
#nullable enable

namespace LangSmith
{
    public partial class ApiKeyClient
    {
        partial void PrepareGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::System.AllOf<global::LangSmith.APIKeyCreateRequest> request);
        partial void PrepareGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AllOf<global::LangSmith.APIKeyCreateRequest> request);
        partial void ProcessGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Personal Access Token<br/>
        /// Generate a Personal Access Token the user
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenApiV1ApiKeyCurrentPostAsync(
            global::System.AllOf<global::LangSmith.APIKeyCreateRequest> request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/api-key/current", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.NullableAllOfAPIKeyCreateRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostRequest(
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
            ProcessGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGeneratePersonalAccessTokenApiV1ApiKeyCurrentPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.APIKeyCreateResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate Personal Access Token<br/>
        /// Generate a Personal Access Token the user
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.APIKeyCreateResponse> GeneratePersonalAccessTokenApiV1ApiKeyCurrentPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::System.AllOf<global::LangSmith.APIKeyCreateRequest>
            {
            };

            return await GeneratePersonalAccessTokenApiV1ApiKeyCurrentPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}