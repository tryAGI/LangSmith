
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareUpdateChartApiV1ChartsChartIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chartId,
            global::LangSmith.CustomChartUpdate request);
        partial void PrepareUpdateChartApiV1ChartsChartIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chartId,
            global::LangSmith.CustomChartUpdate request);
        partial void ProcessUpdateChartApiV1ChartsChartIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateChartApiV1ChartsChartIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartApiV1ChartsChartIdPatchAsync(
            string chartId,
            global::LangSmith.CustomChartUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateChartApiV1ChartsChartIdPatchArguments(
                httpClient: _httpClient,
                chartId: ref chartId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/charts/{chartId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.CustomChartUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateChartApiV1ChartsChartIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                chartId: chartId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateChartApiV1ChartsChartIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateChartApiV1ChartsChartIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CustomChartResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Chart<br/>
        /// Update a chart.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType"></param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartApiV1ChartsChartIdPatchAsync(
            string chartId,
            global::System.AnyOf<string?, global::LangSmith.Missing>? title = default,
            global::System.AnyOf<string?, global::LangSmith.Missing, object>? description = default,
            global::System.AnyOf<int?, global::LangSmith.Missing>? index = default,
            global::System.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series = default,
            global::System.AnyOf<string, global::LangSmith.Missing>? sectionId = default,
            global::System.AnyOf<global::LangSmith.CustomChartUpdateMetadata, global::LangSmith.Missing, object>? metadata = default,
            global::System.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.CustomChartUpdate
            {
                Title = title,
                Description = description,
                Index = index,
                ChartType = chartType,
                Series = series,
                SectionId = sectionId,
                Metadata = metadata,
                CommonFilters = commonFilters,
            };

            return await UpdateChartApiV1ChartsChartIdPatchAsync(
                chartId: chartId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}