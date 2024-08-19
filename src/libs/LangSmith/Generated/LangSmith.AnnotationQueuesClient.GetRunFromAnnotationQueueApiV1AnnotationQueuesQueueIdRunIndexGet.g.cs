
#nullable enable

namespace LangSmith
{
    public partial class AnnotationQueuesClient
    {
        partial void PrepareGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string queueId,
            ref int index);
        partial void PrepareGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string queueId,
            int index);
        partial void ProcessGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Run From Annotation Queue
        /// </summary>
        /// <param name="queueId"></param>
        /// <param name="index"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RunSchemaWithAnnotationQueueInfo> GetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetAsync(
            string queueId,
            int index,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetArguments(
                httpClient: _httpClient,
                queueId: ref queueId,
                index: ref index);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/annotation-queues/{queueId}/run/{index}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                queueId: queueId,
                index: index);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetRunFromAnnotationQueueApiV1AnnotationQueuesQueueIdRunIndexGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.RunSchemaWithAnnotationQueueInfo) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}