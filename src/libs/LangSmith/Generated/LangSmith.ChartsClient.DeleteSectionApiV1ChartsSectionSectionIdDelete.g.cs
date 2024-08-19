
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareDeleteSectionApiV1ChartsSectionSectionIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sectionId);
        partial void PrepareDeleteSectionApiV1ChartsSectionSectionIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sectionId);
        partial void ProcessDeleteSectionApiV1ChartsSectionSectionIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteSectionApiV1ChartsSectionSectionIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Section<br/>
        /// Delete a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteSectionApiV1ChartsSectionSectionIdDeleteResponse> DeleteSectionApiV1ChartsSectionSectionIdDeleteAsync(
            string sectionId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteSectionApiV1ChartsSectionSectionIdDeleteArguments(
                httpClient: _httpClient,
                sectionId: ref sectionId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/charts/section/{sectionId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteSectionApiV1ChartsSectionSectionIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sectionId: sectionId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteSectionApiV1ChartsSectionSectionIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteSectionApiV1ChartsSectionSectionIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteSectionApiV1ChartsSectionSectionIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}