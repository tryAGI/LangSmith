
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareCreateChartArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.CustomChartCreate request);
        partial void PrepareCreateChartRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.CustomChartCreate request);
        partial void ProcessCreateChartResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateChartResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> CreateChartAsync(
            global::LangSmith.CustomChartCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateChartArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/charts/create", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateChartRequest(
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
            ProcessCreateChartResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateChartResponseContent(
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
        /// Create Chart<br/>
        /// Create a new chart.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="description"></param>
        /// <param name="index"></param>
        /// <param name="chartType">
        /// Enum for custom chart types.
        /// </param>
        /// <param name="series"></param>
        /// <param name="sectionId"></param>
        /// <param name="metadata"></param>
        /// <param name="commonFilters"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CustomChartResponse> CreateChartAsync(
            string title,
            global::LangSmith.CustomChartType chartType,
            global::System.Collections.Generic.IList<global::LangSmith.CustomChartSeriesCreate> series,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<int?, object>? index = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? sectionId = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartCreateMetadata, object>? metadata = default,
            global::LangSmith.AnyOf<global::LangSmith.CustomChartSeriesFilters, object>? commonFilters = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.CustomChartCreate
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

            return await CreateChartAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}