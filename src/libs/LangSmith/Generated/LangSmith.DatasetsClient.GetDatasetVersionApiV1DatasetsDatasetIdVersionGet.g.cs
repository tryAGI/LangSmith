
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareGetDatasetVersionApiV1DatasetsDatasetIdVersionGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref global::System.AnyOf<global::System.DateTime?, object>? asOf,
            ref global::System.AnyOf<string, object>? tag);
        partial void PrepareGetDatasetVersionApiV1DatasetsDatasetIdVersionGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, object>? asOf,
            global::System.AnyOf<string, object>? tag);
        partial void ProcessGetDatasetVersionApiV1DatasetsDatasetIdVersionGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDatasetVersionApiV1DatasetsDatasetIdVersionGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Dataset Version<br/>
        /// Get dataset version by as_of or exact tag.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf"></param>
        /// <param name="tag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetVersion> GetDatasetVersionApiV1DatasetsDatasetIdVersionGetAsync(
            string datasetId,
            global::System.AnyOf<global::System.DateTime?, object>? asOf,
            global::System.AnyOf<string, object>? tag,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetDatasetVersionApiV1DatasetsDatasetIdVersionGetArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                asOf: ref asOf,
                tag: ref tag);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/version?as_of={asOf}&tag={tag}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetDatasetVersionApiV1DatasetsDatasetIdVersionGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                asOf: asOf,
                tag: tag);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetDatasetVersionApiV1DatasetsDatasetIdVersionGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetDatasetVersionApiV1DatasetsDatasetIdVersionGetResponseContent(
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
    }
}