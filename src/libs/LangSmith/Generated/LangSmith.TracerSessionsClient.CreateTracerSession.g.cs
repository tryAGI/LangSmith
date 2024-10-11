
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareCreateTracerSessionArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool? upsert,
            global::LangSmith.TracerSessionCreate request);
        partial void PrepareCreateTracerSessionRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? upsert,
            global::LangSmith.TracerSessionCreate request);
        partial void ProcessCreateTracerSessionResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTracerSessionResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            global::LangSmith.TracerSessionCreate request,
            bool? upsert = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTracerSessionArguments(
                httpClient: _httpClient,
                upsert: ref upsert,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/api/v1/sessions",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("upsert", upsert?.ToString()) 
                ; 
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
            PrepareCreateTracerSessionRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                upsert: upsert,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateTracerSessionResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTracerSessionResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.TracerSessionWithoutVirtualFields), JsonSerializerContext) as global::LangSmith.TracerSessionWithoutVirtualFields ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Tracer Session<br/>
        /// Create a new session.
        /// </summary>
        /// <param name="upsert">
        /// Default Value: false
        /// </param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="extra"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDatasetId"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="traceTier"></param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionAsync(
            bool? upsert = false,
            global::System.DateTime? startTime = default,
            global::LangSmith.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::LangSmith.AnyOf<object, object>? extra = default,
            string? name = default,
            global::LangSmith.AnyOf<string, object>? description = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? defaultDatasetId = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? referenceDatasetId = default,
            global::LangSmith.AnyOf<global::LangSmith.TraceTier3?, object>? traceTier = default,
            global::LangSmith.AnyOf<global::System.Guid?, object>? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.TracerSessionCreate
            {
                StartTime = startTime,
                EndTime = endTime,
                Extra = extra,
                Name = name,
                Description = description,
                DefaultDatasetId = defaultDatasetId,
                ReferenceDatasetId = referenceDatasetId,
                TraceTier = traceTier,
                Id = id,
            };

            return await CreateTracerSessionAsync(
                upsert: upsert,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}