
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareUpdateTracerSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid sessionId,
            global::LangSmith.TracerSessionUpdate request);
        partial void PrepareUpdateTracerSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid sessionId,
            global::LangSmith.TracerSessionUpdate request);
        partial void ProcessUpdateTracerSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateTracerSessionResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            global::LangSmith.TracerSessionUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateTracerSessionArguments(
                httpClient: HttpClient,
                sessionId: ref sessionId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/sessions/{sessionId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUpdateTracerSessionRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                sessionId: sessionId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateTracerSessionResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateTracerSessionResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::LangSmith.TracerSessionWithoutVirtualFields.FromJson(__content, JsonSerializerContext) ??
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> UpdateTracerSessionAsync(
            global::System.Guid sessionId,
            string? name = default,
            string? description = default,
            global::System.Guid? defaultDatasetId = default,
            global::System.DateTime? endTime = default,
            object? extra = default,
            global::LangSmith.TraceTier? traceTier = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.TracerSessionUpdate
            {
                Name = name,
                Description = description,
                DefaultDatasetId = defaultDatasetId,
                EndTime = endTime,
                Extra = extra,
                TraceTier = traceTier,
            };

            return await UpdateTracerSessionAsync(
                sessionId: sessionId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}