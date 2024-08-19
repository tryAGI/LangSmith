
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareMonitorTracerSessionApiV1RunsMonitorPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.MonitorRequest request);
        partial void PrepareMonitorTracerSessionApiV1RunsMonitorPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.MonitorRequest request);
        partial void ProcessMonitorTracerSessionApiV1RunsMonitorPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessMonitorTracerSessionApiV1RunsMonitorPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.MonitorResponse> MonitorTracerSessionApiV1RunsMonitorPostAsync(
            global::LangSmith.MonitorRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareMonitorTracerSessionApiV1RunsMonitorPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs/monitor", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.MonitorRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareMonitorTracerSessionApiV1RunsMonitorPostRequest(
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
            ProcessMonitorTracerSessionApiV1RunsMonitorPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessMonitorTracerSessionApiV1RunsMonitorPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.MonitorResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Monitor Tracer Session<br/>
        /// Get monitoring data for a specific session.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="interval"></param>
        /// <param name="stride"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.MonitorResponse> MonitorTracerSessionApiV1RunsMonitorPostAsync(
            global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec> groups,
            string? timezone = "UTC",
            global::System.AllOf<global::LangSmith.TimedeltaInput>? interval = default,
            global::System.AllOf<global::LangSmith.TimedeltaInput>? stride = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.MonitorRequest
            {
                Timezone = timezone,
                Groups = groups,
                Interval = interval,
                Stride = stride,
            };

            return await MonitorTracerSessionApiV1RunsMonitorPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}