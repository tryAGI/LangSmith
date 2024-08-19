
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareShareDatasetApiV1DatasetsDatasetIdSharePutArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref bool shareProjects);
        partial void PrepareShareDatasetApiV1DatasetsDatasetIdSharePutRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            bool shareProjects);
        partial void ProcessShareDatasetApiV1DatasetsDatasetIdSharePutResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessShareDatasetApiV1DatasetsDatasetIdSharePutResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Share Dataset<br/>
        /// Share a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="shareProjects">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DatasetShareSchema> ShareDatasetApiV1DatasetsDatasetIdSharePutAsync(
            string datasetId,
            bool shareProjects,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareShareDatasetApiV1DatasetsDatasetIdSharePutArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                shareProjects: ref shareProjects);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/share?share_projects={shareProjects}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareShareDatasetApiV1DatasetsDatasetIdSharePutRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                shareProjects: shareProjects);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessShareDatasetApiV1DatasetsDatasetIdSharePutResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessShareDatasetApiV1DatasetsDatasetIdSharePutResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DatasetShareSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}