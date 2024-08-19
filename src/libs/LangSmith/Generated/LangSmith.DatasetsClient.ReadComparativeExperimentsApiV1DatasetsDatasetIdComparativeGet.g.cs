
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref global::System.AnyOf<string?, object>? name,
            ref global::System.AnyOf<string?, object>? nameContains,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            ref int offset,
            ref int limit,
            ref global::System.AllOf<global::LangSmith.SortByComparativeExperimentColumn?>? sortBy,
            ref bool sortByDesc);
        partial void PrepareReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.SortByComparativeExperimentColumn?>? sortBy,
            bool sortByDesc);
        partial void ProcessReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Comparative Experiments<br/>
        /// Get all comparative experiments for a given dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="name"></param>
        /// <param name="nameContains"></param>
        /// <param name="id"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="sortBy">
        /// Default Value: created_at
        /// </param>
        /// <param name="sortByDesc">
        /// Default Value: true
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.ComparativeExperiment>> ReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetAsync(
            string datasetId,
            global::System.AnyOf<string?, object>? name,
            global::System.AnyOf<string?, object>? nameContains,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? id,
            int offset,
            int limit,
            global::System.AllOf<global::LangSmith.SortByComparativeExperimentColumn?>? sortBy,
            bool sortByDesc,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetArguments(
                httpClient: _httpClient,
                datasetId: ref datasetId,
                name: ref name,
                nameContains: ref nameContains,
                id: ref id,
                offset: ref offset,
                limit: ref limit,
                sortBy: ref sortBy,
                sortByDesc: ref sortByDesc);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/{datasetId}/comparative?name={name}&name_contains={nameContains}&id={id}&offset={offset}&limit={limit}&sort_by={sortBy}&sort_by_desc={sortByDesc}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                datasetId: datasetId,
                name: name,
                nameContains: nameContains,
                id: id,
                offset: offset,
                limit: limit,
                sortBy: sortBy,
                sortByDesc: sortByDesc);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadComparativeExperimentsApiV1DatasetsDatasetIdComparativeGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListComparativeExperiment) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}