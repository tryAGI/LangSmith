
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            global::LangSmith.AnnotationQueueUpdateSchema request);
        partial void PrepareUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            global::LangSmith.AnnotationQueueUpdateSchema request);
        partial void ProcessUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse> UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchAsync(
            string queueId,
            global::LangSmith.AnnotationQueueUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.AnnotationQueueUpdateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="defaultDataset"></param>
        /// <param name="numReviewersPerItem">
        /// Default Value: 1
        /// </param>
        /// <param name="enableReservations">
        /// Default Value: true
        /// </param>
        /// <param name="reservationMinutes"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchResponse> UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchAsync(
            string queueId,
            global::System.AnyOf<string, object>? name = default,
            global::System.AnyOf<string, object>? description = default,
            global::System.AnyOf<string, object>? defaultDataset = default,
            global::System.AnyOf<int?, object>? numReviewersPerItem = default,
            bool enableReservations = true,
            global::System.AnyOf<int?, object>? reservationMinutes = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.AnnotationQueueUpdateSchema
            {
                Name = name,
                Description = description,
                DefaultDataset = defaultDataset,
                NumReviewersPerItem = numReviewersPerItem,
                EnableReservations = enableReservations,
                ReservationMinutes = reservationMinutes,
            };

            return await UpdateAnnotationQueueApiV1AnnotationQueuesQueueIdPatchAsync(
                queueId: queueId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}