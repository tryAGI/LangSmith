
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareUpdateSectionApiV1ChartsSectionSectionIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sectionId,
            global::LangSmith.CustomChartsSectionUpdate request);
        partial void PrepareUpdateSectionApiV1ChartsSectionSectionIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sectionId,
            global::LangSmith.CustomChartsSectionUpdate request);
        partial void ProcessUpdateSectionApiV1ChartsSectionSectionIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateSectionApiV1ChartsSectionSectionIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> UpdateSectionApiV1ChartsSectionSectionIdPatchAsync(
            string sectionId,
            global::LangSmith.CustomChartsSectionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateSectionApiV1ChartsSectionSectionIdPatchArguments(
                httpClient: _httpClient,
                sectionId: ref sectionId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/charts/section/{sectionId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.CustomChartsSectionUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateSectionApiV1ChartsSectionSectionIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sectionId: sectionId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateSectionApiV1ChartsSectionSectionIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateSectionApiV1ChartsSectionSectionIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CustomChartsSectionResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Section<br/>
        /// Update a section.
        /// </summary>
        /// <param name="sectionId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartsSectionResponse> UpdateSectionApiV1ChartsSectionSectionIdPatchAsync(
            string sectionId,
            global::System.AnyOf<string, global::LangSmith.Missing>? title = default,
            global::System.AnyOf<string, global::LangSmith.Missing, object>? description = default,
            global::System.AnyOf<int?, global::LangSmith.Missing>? index = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.CustomChartsSectionUpdate
            {
                Title = title,
                Description = description,
                Index = index,
            };

            return await UpdateSectionApiV1ChartsSectionSectionIdPatchAsync(
                sectionId: sectionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}