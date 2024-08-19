
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request);
        partial void PrepareUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request);
        partial void ProcessUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutAsync(
            string datasetId,
            global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/splits", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutRequest(
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
            ProcessUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListString) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Dataset Splits
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="splitName"></param>
        /// <param name="examples"></param>
        /// <param name="remove">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<string>> UpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutAsync(
            string datasetId,
            string splitName,
            global::System.Collections.Generic.IList<string> examples,
            bool remove = false,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.BodyUpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPut
            {
                SplitName = splitName,
                Examples = examples,
                Remove = remove,
            };

            return await UpdateDatasetSplitsApiV1DatasetsDatasetIdSplitsPutAsync(
                datasetId: datasetId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}