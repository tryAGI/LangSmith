
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareUpdateChartArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid chartId,
            global::LangSmith.CustomChartUpdate request);
        partial void PrepareUpdateChartRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid chartId,
            global::LangSmith.CustomChartUpdate request);
        partial void ProcessUpdateChartResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateChartResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::LangSmith.CustomChartUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateChartArguments(
                httpClient: _httpClient,
                chartId: ref chartId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/charts/{chartId}",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateChartRequest(
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
            ProcessUpdateChartResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateChartResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.CustomChartResponse), JsonSerializerContext) as global::LangSmith.CustomChartResponse ??
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> UpdateChartAsync(
            global::System.Guid chartId,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing>? title = default,
            global::LangSmith.AnyOf<string, global::LangSmith.Missing, object>? description = default,
            global::LangSmith.AnyOf<int?, global::LangSmith.Missing>? index = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartType?, global::LangSmith.Missing>? chartType = default,
            global::LangSmith.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesUpdate>, global::LangSmith.Missing>? series = default,
            global::LangSmith.AnyOf<global::System.Guid?, global::LangSmith.Missing>? sectionId = default,
            global::LangSmith.AnyOf<object, global::LangSmith.Missing, object>? metadata = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, global::LangSmith.Missing, object>? commonFilters = default,
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

            return await UpdateChartAsync(
                chartId: chartId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}