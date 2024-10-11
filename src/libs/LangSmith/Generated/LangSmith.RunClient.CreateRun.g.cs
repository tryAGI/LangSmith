
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareCreateRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.CreateRunRequest request);
        partial void PrepareCreateRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.CreateRunRequest request);
        partial void ProcessCreateRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            global::LangSmith.CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateRunArguments(
                httpClient: _httpClient,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/runs",
                baseUri: _httpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
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
            PrepareCreateRunRequest(
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
            ProcessCreateRunResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateRunResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.CreateRunApiV1RunsPostResponse), JsonSerializerContext) as global::LangSmith.CreateRunApiV1RunsPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Run<br/>
        /// Create a new run.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="inputs"></param>
        /// <param name="runType"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="error"></param>
        /// <param name="serialized"></param>
        /// <param name="outputs"></param>
        /// <param name="parentRunId"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="id"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="referenceExampleId"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunAsync(
            string name,
            global::LangSmith.CreateRunRequestRunType runType,
            global::LangSmith.OneOf<object, object>? inputs = default,
            global::LangSmith.OneOf<string, double?, object>? startTime = default,
            global::LangSmith.OneOf<string, double?, object>? endTime = default,
            global::LangSmith.OneOf<object, object>? extra = default,
            global::LangSmith.OneOf<string, object>? error = default,
            global::LangSmith.OneOf<object, object>? serialized = default,
            global::LangSmith.OneOf<object, object>? outputs = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? parentRunId = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<object>, object>? events = default,
            global::LangSmith.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? traceId = default,
            global::LangSmith.OneOf<string, object>? dottedOrder = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? id = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? sessionId = default,
            global::LangSmith.OneOf<string, object>? sessionName = default,
            global::LangSmith.OneOf<global::System.Guid?, object>? referenceExampleId = default,
            global::LangSmith.OneOf<object, object>? inputAttachments = default,
            global::LangSmith.OneOf<object, object>? outputAttachments = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.CreateRunRequest
            {
                Name = name,
                Inputs = inputs,
                RunType = runType,
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Error = error,
                Serialized = serialized,
                Outputs = outputs,
                ParentRunId = parentRunId,
                Events = events,
                Tags = tags,
                TraceId = traceId,
                DottedOrder = dottedOrder,
                Id = id,
                SessionId = sessionId,
                SessionName = sessionName,
                ReferenceExampleId = referenceExampleId,
                InputAttachments = inputAttachments,
                OutputAttachments = outputAttachments,
            };

            return await CreateRunAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}