
#nullable enable

namespace LangSmith
{
    public partial class TracerSessionsClient
    {
        partial void PrepareCreateTracerSessionApiV1SessionsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref bool upsert,
            global::LangSmith.TracerSessionCreate request);
        partial void PrepareCreateTracerSessionApiV1SessionsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool upsert,
            global::LangSmith.TracerSessionCreate request);
        partial void ProcessCreateTracerSessionApiV1SessionsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTracerSessionApiV1SessionsPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionApiV1SessionsPostAsync(
            global::LangSmith.TracerSessionCreate request,
            bool upsert = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateTracerSessionApiV1SessionsPostArguments(
                httpClient: _httpClient,
                upsert: ref upsert,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/sessions?upsert={upsert}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.TracerSessionCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateTracerSessionApiV1SessionsPostRequest(
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
            ProcessCreateTracerSessionApiV1SessionsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateTracerSessionApiV1SessionsPostResponseContent(
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
        public async global::System.Threading.Tasks.Task<global::LangSmith.TracerSessionWithoutVirtualFields> CreateTracerSessionApiV1SessionsPostAsync(
            bool upsert = false,
            global::System.DateTime startTime = default,
            global::System.AnyOf<global::System.DateTime?, object>? endTime = default,
            global::System.AnyOf<global::LangSmith.TracerSessionCreateExtra, object>? extra = default,
            string? name = default,
            global::System.AnyOf<string, object>? description = default,
            global::System.AnyOf<string, object>? defaultDatasetId = default,
            global::System.AnyOf<string, object>? referenceDatasetId = default,
            global::System.AnyOf<global::LangSmith.TraceTier3?, object>? traceTier = default,
            global::System.AnyOf<string, object>? id = default,
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

            return await CreateTracerSessionApiV1SessionsPostAsync(
                upsert: upsert,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}