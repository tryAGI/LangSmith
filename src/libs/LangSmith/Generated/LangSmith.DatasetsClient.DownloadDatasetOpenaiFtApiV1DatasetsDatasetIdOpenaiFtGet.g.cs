
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref global::System.AnyOf<global::System.DateTime?, object>? asOf);
        partial void PrepareDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, object>? asOf);
        partial void ProcessDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Download Dataset Openai Ft<br/>
        /// Download a dataset as OpenAI Jsonl format.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponse> DownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetAsync(
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, object>? asOf = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                asOf: ref asOf);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/openai_ft?as_of={asOf}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                asOf: asOf);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DownloadDatasetOpenaiFtApiV1DatasetsDatasetIdOpenaiFtGetResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}