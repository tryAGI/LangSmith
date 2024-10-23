
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareUpdateRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid runId,
            global::LangSmith.UpdateRunRequest request);
        partial void PrepareUpdateRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid runId,
            global::LangSmith.UpdateRunRequest request);
        partial void ProcessUpdateRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateRunAsync(
            global::System.Guid runId,
            global::LangSmith.UpdateRunRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUpdateRunArguments(
                httpClient: HttpClient,
                runId: ref runId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/api/v1/runs/{runId}",
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
            PrepareUpdateRunRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                runId: runId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUpdateRunResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUpdateRunResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Update Run<br/>
        /// Update a run.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="traceId"></param>
        /// <param name="dottedOrder"></param>
        /// <param name="parentRunId"></param>
        /// <param name="endTime"></param>
        /// <param name="error"></param>
        /// <param name="inputs"></param>
        /// <param name="outputs"></param>
        /// <param name="events"></param>
        /// <param name="tags"></param>
        /// <param name="extra"></param>
        /// <param name="inputAttachments"></param>
        /// <param name="outputAttachments"></param>
        /// <param name="sessionId"></param>
        /// <param name="sessionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> UpdateRunAsync(
            global::System.Guid runId,
            global::System.Guid? traceId = default,
            string? dottedOrder = default,
            global::System.Guid? parentRunId = default,
            global::LangSmith.OneOf<string, double?>? endTime = default,
            string? error = default,
            object? inputs = default,
            object? outputs = default,
            global::System.Collections.Generic.IList<object>? events = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            object? extra = default,
            object? inputAttachments = default,
            object? outputAttachments = default,
            global::System.Guid? sessionId = default,
            string? sessionName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::LangSmith.UpdateRunRequest
            {
                TraceId = traceId,
                DottedOrder = dottedOrder,
                ParentRunId = parentRunId,
                EndTime = endTime,
                Error = error,
                Inputs = inputs,
                Outputs = outputs,
                Events = events,
                Tags = tags,
                Extra = extra,
                InputAttachments = inputAttachments,
                OutputAttachments = outputAttachments,
                SessionId = sessionId,
                SessionName = sessionName,
            };

            return await UpdateRunAsync(
                runId: runId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}