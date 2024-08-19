
#nullable enable

namespace LangSmith
{
    public partial class PlaygroundSettingsClient
    {
        partial void PrepareDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string playgroundSettingsId);
        partial void PrepareDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string playgroundSettingsId);
        partial void ProcessDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Playground Settings<br/>
        /// Delete playground settings.
        /// </summary>
        /// <param name="playgroundSettingsId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse> DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteAsync(
            string playgroundSettingsId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteArguments(
                httpClient: _httpClient,
                playgroundSettingsId: ref playgroundSettingsId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/playground-settings/{playgroundSettingsId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                playgroundSettingsId: playgroundSettingsId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeletePlaygroundSettingsApiV1PlaygroundSettingsPlaygroundSettingsIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}