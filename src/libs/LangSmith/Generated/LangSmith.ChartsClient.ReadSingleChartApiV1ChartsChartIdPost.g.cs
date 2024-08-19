
#nullable enable

namespace LangSmith
{
    public partial class ChartsClient
    {
        partial void PrepareReadSingleChartApiV1ChartsChartIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string chartId,
            global::LangSmith.CustomChartsRequest request);
        partial void PrepareReadSingleChartApiV1ChartsChartIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string chartId,
            global::LangSmith.CustomChartsRequest request);
        partial void ProcessReadSingleChartApiV1ChartsChartIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSingleChartApiV1ChartsChartIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Single Chart<br/>
        /// Get a single chart by ID.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponse> ReadSingleChartApiV1ChartsChartIdPostAsync(
            string chartId,
            global::LangSmith.CustomChartsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadSingleChartApiV1ChartsChartIdPostArguments(
                httpClient: _httpClient,
                chartId: ref chartId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/charts/{chartId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.CustomChartsRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSingleChartApiV1ChartsChartIdPostRequest(
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
            ProcessReadSingleChartApiV1ChartsChartIdPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSingleChartApiV1ChartsChartIdPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.SingleCustomChartResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Single Chart<br/>
        /// Get a single chart by ID.
        /// </summary>
        /// <param name="chartId"></param>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="stride"></param>
        /// <param name="afterIndex"></param>
        /// <param name="tagValueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SingleCustomChartResponse> ReadSingleChartApiV1ChartsChartIdPostAsync(
            string chartId,
            global::System.DateTime startTime,
            string? timezone = "UTC",
            global::System.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::System.AllOf<global::LangSmith.TimedeltaInput>? stride = default,
            global::System.AnyOf<int?, object>? afterIndex = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? tagValueId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.CustomChartsRequest
            {
                Timezone = timezone,
                StartTime = startTime,
                EndTime = endTime,
                Stride = stride,
                AfterIndex = afterIndex,
                TagValueId = tagValueId,
            };

            return await ReadSingleChartApiV1ChartsChartIdPostAsync(
                chartId: chartId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}