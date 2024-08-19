
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareUploadExperimentApiV1DatasetsUploadExperimentPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ExperimentResultsUpload request);
        partial void PrepareUploadExperimentApiV1DatasetsUploadExperimentPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ExperimentResultsUpload request);
        partial void ProcessUploadExperimentApiV1DatasetsUploadExperimentPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadExperimentApiV1DatasetsUploadExperimentPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ExperimentResultsUploadResult> UploadExperimentApiV1DatasetsUploadExperimentPostAsync(
            global::LangSmith.ExperimentResultsUpload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUploadExperimentApiV1DatasetsUploadExperimentPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets/upload-experiment", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ExperimentResultsUpload);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUploadExperimentApiV1DatasetsUploadExperimentPostRequest(
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
            ProcessUploadExperimentApiV1DatasetsUploadExperimentPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUploadExperimentApiV1DatasetsUploadExperimentPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ExperimentResultsUploadResult) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload Experiment<br/>
        /// Upload an experiment that has already been run.
        /// </summary>
        /// <param name="experimentName"></param>
        /// <param name="experimentDescription"></param>
        /// <param name="datasetId"></param>
        /// <param name="datasetName"></param>
        /// <param name="datasetDescription"></param>
        /// <param name="summaryExperimentScores"></param>
        /// <param name="results"></param>
        /// <param name="experimentStartTime"></param>
        /// <param name="experimentEndTime"></param>
        /// <param name="experimentMetadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ExperimentResultsUploadResult> UploadExperimentApiV1DatasetsUploadExperimentPostAsync(
            string experimentName,
            global::System.Collections.Generic.IList<global::LangSmith.ExperimentResultRow> results,
            global::System.DateTime experimentStartTime,
            global::System.DateTime experimentEndTime,
            global::System.AnyOf<string?, object>? experimentDescription = default,
            global::System.AnyOf<string, object>? datasetId = default,
            global::System.AnyOf<string?, object>? datasetName = default,
            global::System.AnyOf<string?, object>? datasetDescription = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.FeedbackCreateCoreSchema>, object>? summaryExperimentScores = default,
            global::System.AnyOf<global::LangSmith.ExperimentResultsUploadExperimentMetadata, object>? experimentMetadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ExperimentResultsUpload
            {
                ExperimentName = experimentName,
                ExperimentDescription = experimentDescription,
                DatasetId = datasetId,
                DatasetName = datasetName,
                DatasetDescription = datasetDescription,
                SummaryExperimentScores = summaryExperimentScores,
                Results = results,
                ExperimentStartTime = experimentStartTime,
                ExperimentEndTime = experimentEndTime,
                ExperimentMetadata = experimentMetadata,
            };

            return await UploadExperimentApiV1DatasetsUploadExperimentPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}