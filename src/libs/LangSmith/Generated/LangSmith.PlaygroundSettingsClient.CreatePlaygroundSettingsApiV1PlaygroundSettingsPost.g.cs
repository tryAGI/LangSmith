
#nullable enable

namespace LangSmith
{
    public partial class PlaygroundSettingsClient
    {
        partial void PrepareCreatePlaygroundSettingsApiV1PlaygroundSettingsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.PlaygroundSettingsCreateRequest request);
        partial void PrepareCreatePlaygroundSettingsApiV1PlaygroundSettingsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.PlaygroundSettingsCreateRequest request);
        partial void ProcessCreatePlaygroundSettingsApiV1PlaygroundSettingsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreatePlaygroundSettingsApiV1PlaygroundSettingsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> CreatePlaygroundSettingsApiV1PlaygroundSettingsPostAsync(
            global::LangSmith.PlaygroundSettingsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreatePlaygroundSettingsApiV1PlaygroundSettingsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/playground-settings", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.PlaygroundSettingsCreateRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreatePlaygroundSettingsApiV1PlaygroundSettingsPostRequest(
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
            ProcessCreatePlaygroundSettingsApiV1PlaygroundSettingsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreatePlaygroundSettingsApiV1PlaygroundSettingsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.PlaygroundSettingsResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Playground Settings<br/>
        /// Create playground settings.
        /// </summary>
        /// <param name="settings"></param>
        /// <param name="name"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.PlaygroundSettingsResponse> CreatePlaygroundSettingsApiV1PlaygroundSettingsPostAsync(
            global::LangSmith.PlaygroundSettingsCreateRequestSettings settings,
            global::System.AnyOf<string, object>? name = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.PlaygroundSettingsCreateRequest
            {
                Settings = settings,
                Name = name,
            };

            return await CreatePlaygroundSettingsApiV1PlaygroundSettingsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}