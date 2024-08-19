
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            ref string queueRunId,
            global::LangSmith.AnnotationQueueRunUpdateSchema request);
        partial void PrepareUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            string queueRunId,
            global::LangSmith.AnnotationQueueRunUpdateSchema request);
        partial void ProcessUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse> UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchAsync(
            string queueId,
            string queueRunId,
            global::LangSmith.AnnotationQueueRunUpdateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                queueRunId: ref queueRunId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/runs/{queueRunId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.AnnotationQueueRunUpdateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                queueRunId: queueRunId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Run In Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="lastReviewedTime"></param>
        /// <param name="addedAt"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchResponse> UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchAsync(
            string queueId,
            string queueRunId,
            global::System.AnyOf<global::System.DateTime?, object>? lastReviewedTime = default,
            global::System.AnyOf<global::System.DateTime?, object>? addedAt = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.AnnotationQueueRunUpdateSchema
            {
                LastReviewedTime = lastReviewedTime,
                AddedAt = addedAt,
            };

            return await UpdateRunInAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdPatchAsync(
                queueId: queueId,
                queueRunId: queueRunId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}