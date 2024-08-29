
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string annotationQueueRunId,
            global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema request);
        partial void PrepareCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string annotationQueueRunId,
            global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema request);
        partial void ProcessCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostAsync(
            string annotationQueueRunId,
            global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostArguments(
                httpClient: _httpClient,
                annotationQueueRunId: ref annotationQueueRunId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/status/{annotationQueueRunId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.IdentityAnnotationQueueRunStatusCreateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                annotationQueueRunId: annotationQueueRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Identity Annotation Queue Run Status
        /// </summary>
        /// <param name="annotationQueueRunId"></param>
        /// <param name="status"></param>
        /// <param name="overrideAddedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostResponse> CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostAsync(
            string annotationQueueRunId,
            global::System.AnyOf<string, object>? status = default,
            global::System.AnyOf<global::System.DateTime?, object>? overrideAddedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.IdentityAnnotationQueueRunStatusCreateSchema
            {
                Status = status,
                OverrideAddedAt = overrideAddedAt,
            };

            return await CreateIdentityAnnotationQueueRunStatusApiV1AnnotationQueuesStatusAnnotationQueueRunIdPostAsync(
                annotationQueueRunId: annotationQueueRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}