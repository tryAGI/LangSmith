
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareCreateAnnotationQueueApiV1AnnotationQueuesPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.AnnotationQueueCreateSchema request);
        partial void PrepareCreateAnnotationQueueApiV1AnnotationQueuesPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.AnnotationQueueCreateSchema request);
        partial void ProcessCreateAnnotationQueueApiV1AnnotationQueuesPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateAnnotationQueueApiV1AnnotationQueuesPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSchema> CreateAnnotationQueueApiV1AnnotationQueuesPostAsync(
            global::LangSmith.AnnotationQueueCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateAnnotationQueueApiV1AnnotationQueuesPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/annotation-queues", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.AnnotationQueueCreateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateAnnotationQueueApiV1AnnotationQueuesPostRequest(
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
            ProcessCreateAnnotationQueueApiV1AnnotationQueuesPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateAnnotationQueueApiV1AnnotationQueuesPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.AnnotationQueueSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Annotation Queue
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes">
        /// Default Value: 1
        /// </param>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSchema> CreateAnnotationQueueApiV1AnnotationQueuesPostAsync(
            string name,
            global::System.AnyOf<string?, object>? description = default,
            global::System.DateTime createdAt = default,
            global::System.DateTime updatedAt = default,
            global::System.AnyOf<string, object>? defaultDataset = default,
            global::System.AnyOf<int?, object>? numReviewersPerItem = default,
            global::System.AnyOf<bool?, object>? enableReservations = default,
            global::System.AnyOf<int?, object>? reservationMinutes = default,
            string? id = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.AnnotationQueueCreateSchema
            {
                Name = name,
                Description = description,
                CreatedAt = createdAt,
                UpdatedAt = updatedAt,
                DefaultDataset = defaultDataset,
                NumReviewersPerItem = numReviewersPerItem,
                EnableReservations = enableReservations,
                ReservationMinutes = reservationMinutes,
                Id = id,
            };

            return await CreateAnnotationQueueApiV1AnnotationQueuesPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}