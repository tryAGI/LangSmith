
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::LangSmith.PutDatasetVersionsSchema request);
        partial void PrepareUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::LangSmith.PutDatasetVersionsSchema request);
        partial void ProcessUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutAsync(
            string datasetId,
            global::LangSmith.PutDatasetVersionsSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/tags", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.PutDatasetVersionsSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutRequest(
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
            ProcessUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DatasetVersion) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Dataset Version<br/>
        /// Set a tag on a dataset version.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> UpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutAsync(
            string datasetId,
            global::System.DateTime asOf,
            string tag,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.PutDatasetVersionsSchema
            {
                AsOf = asOf,
                Tag = tag,
            };

            return await UpdateDatasetVersionApiV1DatasetsDatasetIdTagsPutAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}