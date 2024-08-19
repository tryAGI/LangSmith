
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            ref string queueRunId);
        partial void PrepareDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            string queueRunId);
        partial void ProcessDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="queueRunId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse> DeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteAsync(
            string queueId,
            string queueRunId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                queueRunId: ref queueRunId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/runs/{queueRunId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                queueRunId: queueRunId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunsQueueRunIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}