
#nullable enable

namespace LangSmith
{
    public partial class ExamplesClient
    {
        partial void PrepareDeleteExampleApiV1ExamplesExampleIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string exampleId);
        partial void PrepareDeleteExampleApiV1ExamplesExampleIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string exampleId);
        partial void ProcessDeleteExampleApiV1ExamplesExampleIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteExampleApiV1ExamplesExampleIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Example<br/>
        /// Delete a specific example.
        /// </summary>
        /// <param name="exampleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteExampleApiV1ExamplesExampleIdDeleteResponse> DeleteExampleApiV1ExamplesExampleIdDeleteAsync(
            string exampleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteExampleApiV1ExamplesExampleIdDeleteArguments(
                httpClient: _httpClient,
                exampleId: ref exampleId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/examples/{exampleId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteExampleApiV1ExamplesExampleIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                exampleId: exampleId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteExampleApiV1ExamplesExampleIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteExampleApiV1ExamplesExampleIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteExampleApiV1ExamplesExampleIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}