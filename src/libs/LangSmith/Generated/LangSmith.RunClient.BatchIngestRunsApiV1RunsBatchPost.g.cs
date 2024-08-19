
#nullable enable

namespace LangSmith
{
    public partial class RunClient
    {
        partial void PrepareBatchIngestRunsApiV1RunsBatchPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.BatchIngestRunsRequest request);
        partial void PrepareBatchIngestRunsApiV1RunsBatchPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.BatchIngestRunsRequest request);
        partial void ProcessBatchIngestRunsApiV1RunsBatchPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessBatchIngestRunsApiV1RunsBatchPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse> BatchIngestRunsApiV1RunsBatchPostAsync(
            global::LangSmith.BatchIngestRunsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareBatchIngestRunsApiV1RunsBatchPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/runs/batch", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.BatchIngestRunsRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareBatchIngestRunsApiV1RunsBatchPostRequest(
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
            ProcessBatchIngestRunsApiV1RunsBatchPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessBatchIngestRunsApiV1RunsBatchPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.BatchIngestRunsApiV1RunsBatchPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Batch Ingest Runs<br/>
        /// Batch ingest runs.
        /// </summary>
        /// <param name="post"></param>
        /// <param name="patch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.BatchIngestRunsApiV1RunsBatchPostResponse> BatchIngestRunsApiV1RunsBatchPostAsync(
            global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPostItem>? post = default,
            global::System.Collections.Generic.IList<global::LangSmith.BatchIngestRunsRequestPatchItem>? patch = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BatchIngestRunsRequest
            {
                Post = post,
                Patch = patch,
            };

            return await BatchIngestRunsApiV1RunsBatchPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}