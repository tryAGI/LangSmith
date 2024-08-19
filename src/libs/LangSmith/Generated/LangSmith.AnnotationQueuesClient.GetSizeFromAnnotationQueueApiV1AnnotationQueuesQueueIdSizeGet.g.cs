
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId);
        partial void PrepareGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId);
        partial void ProcessGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Size From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.AnnotationQueueSizeSchema> GetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetAsync(
            string queueId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetArguments(
                httpClient: _httpClient,
                queueId: ref queueId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/size", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSizeFromAnnotationQueueApiV1AnnotationQueuesQueueIdSizeGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.AnnotationQueueSizeSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}