
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareIndexApiV1DatasetsDatasetIdIndexPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::LangSmith.DatasetIndexRequest request);
        partial void PrepareIndexApiV1DatasetsDatasetIdIndexPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::LangSmith.DatasetIndexRequest request);
        partial void ProcessIndexApiV1DatasetsDatasetIdIndexPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessIndexApiV1DatasetsDatasetIdIndexPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexApiV1DatasetsDatasetIdIndexPostAsync(
            string datasetId,
            global::LangSmith.DatasetIndexRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareIndexApiV1DatasetsDatasetIdIndexPostArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/index", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.DatasetIndexRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareIndexApiV1DatasetsDatasetIdIndexPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessIndexApiV1DatasetsDatasetIdIndexPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessIndexApiV1DatasetsDatasetIdIndexPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IndexApiV1DatasetsDatasetIdIndexPostResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Index<br/>
        /// Index a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="tag">
        /// Default Value: latest
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.IndexApiV1DatasetsDatasetIdIndexPostResponse> IndexApiV1DatasetsDatasetIdIndexPostAsync(
            string datasetId,
            global::System.AnyOf<string?, object>? tag = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.DatasetIndexRequest
            {
                Tag = tag,
            };

            return await IndexApiV1DatasetsDatasetIdIndexPostAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}