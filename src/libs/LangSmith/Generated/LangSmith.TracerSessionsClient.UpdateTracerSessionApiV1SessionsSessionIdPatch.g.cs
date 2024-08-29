
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareUpdateTracerSessionApiV1SessionsSessionIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string sessionId,
            global::LangSmith.TracerSessionUpdate request);
        partial void PrepareUpdateTracerSessionApiV1SessionsSessionIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string sessionId,
            global::LangSmith.TracerSessionUpdate request);
        partial void ProcessUpdateTracerSessionApiV1SessionsSessionIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateTracerSessionApiV1SessionsSessionIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionApiV1SessionsSessionIdPatchAsync(
            string sessionId,
            global::LangSmith.TracerSessionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateTracerSessionApiV1SessionsSessionIdPatchArguments(
                httpClient: _httpClient,
                sessionId: ref sessionId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions/{sessionId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TracerSessionUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateTracerSessionApiV1SessionsSessionIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                sessionId: sessionId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateTracerSessionApiV1SessionsSessionIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateTracerSessionApiV1SessionsSessionIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.TracerSessionWithoutVirtualFields) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="traceTier"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionApiV1SessionsSessionIdPatchAsync(
            string sessionId,
            global::System.AnyOf<string, object>? name = default,
            global::System.AnyOf<string, object>? description = default,
            global::System.AnyOf<string, object>? defaultDatasetId = default,
            global::System.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::System.AnyOf<global::LangSmith.TracerSessionUpdateExtra, object>? extra = default,
            global::System.AnyOf<global::LangSmith.TraceTier3?, object>? traceTier = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TracerSessionUpdate
            {
                Name = name,
                Description = description,
                DefaultDatasetId = defaultDatasetId,
                EndTime = endTime,
                Extra = extra,
                TraceTier = traceTier,
            };

            return await UpdateTracerSessionApiV1SessionsSessionIdPatchAsync(
                sessionId: sessionId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}