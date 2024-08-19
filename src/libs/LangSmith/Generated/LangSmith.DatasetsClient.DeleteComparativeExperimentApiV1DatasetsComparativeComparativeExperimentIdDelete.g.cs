
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string comparativeExperimentId);
        partial void PrepareDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string comparativeExperimentId);
        partial void ProcessDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Comparative Experiment<br/>
        /// Delete a specific comparative experiment.
        /// </summary>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse> DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteAsync(
            string comparativeExperimentId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteArguments(
                httpClient: _httpClient,
                comparativeExperimentId: ref comparativeExperimentId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/datasets/comparative/{comparativeExperimentId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                comparativeExperimentId: comparativeExperimentId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteComparativeExperimentApiV1DatasetsComparativeComparativeExperimentIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}