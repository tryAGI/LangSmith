
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareCreateRunApiV1RunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.CreateRunRequest request);
        partial void PrepareCreateRunApiV1RunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.CreateRunRequest request);
        partial void ProcessCreateRunApiV1RunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRunApiV1RunsPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunApiV1RunsPostAsync(
            global::LangSmith.CreateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateRunApiV1RunsPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.CreateRunRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateRunApiV1RunsPostRequest(
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
            ProcessCreateRunApiV1RunsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateRunApiV1RunsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CreateRunApiV1RunsPostResponse) ??
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateRunApiV1RunsPostResponse> CreateRunApiV1RunsPostAsync(
            string name,
            global::LangSmith.CreateRunRequestRunType runType,
            global::System.OneOf<global::LangSmith.CreateRunRequestInputs, object>? inputs = default,
            global::System.OneOf<string?, double?, object>? startTime = default,
            global::System.OneOf<string?, double?, object>? endTime = default,
            global::System.OneOf<global::LangSmith.CreateRunRequestExtra, object>? extra = default,
            global::System.OneOf<string?, object>? error = default,
            global::System.OneOf<global::LangSmith.CreateRunRequestSerialized, object>? serialized = default,
            global::System.OneOf<global::LangSmith.CreateRunRequestOutputs, object>? outputs = default,
            global::System.OneOf<string, object>? parentRunId = default,
            global::System.OneOf<global::System.Collections.Generic.IList<global::LangSmith.CreateRunRequestEventsVariant1Item>, object>? events = default,
            global::System.OneOf<global::System.Collections.Generic.IList<string>, object>? tags = default,
            global::System.OneOf<string, object>? traceId = default,
            global::System.OneOf<string?, object>? dottedOrder = default,
            global::System.OneOf<string, object>? id = default,
            global::System.OneOf<string, object>? sessionId = default,
            global::System.OneOf<string?, object>? sessionName = default,
            global::System.OneOf<string, object>? referenceExampleId = default,
            global::System.OneOf<global::LangSmith.CreateRunRequestInputAttachments, object>? inputAttachments = default,
            global::System.OneOf<global::LangSmith.CreateRunRequestOutputAttachments, object>? outputAttachments = default,
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

            return await CreateRunApiV1RunsPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}