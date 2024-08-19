
#nullable enable

namespace LangSmith
{
    public partial class DatasetsClient
    {
        partial void PrepareCreateComparativeExperimentApiV1DatasetsComparativePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.ComparativeExperimentCreate request);
        partial void PrepareCreateComparativeExperimentApiV1DatasetsComparativePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.ComparativeExperimentCreate request);
        partial void ProcessCreateComparativeExperimentApiV1DatasetsComparativePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateComparativeExperimentApiV1DatasetsComparativePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Comparative Experiment<br/>
        /// Create a comparative experiment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ComparativeExperimentBase> CreateComparativeExperimentApiV1DatasetsComparativePostAsync(
            global::LangSmith.ComparativeExperimentCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateComparativeExperimentApiV1DatasetsComparativePostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/datasets/comparative", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.ComparativeExperimentCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateComparativeExperimentApiV1DatasetsComparativePostRequest(
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
            ProcessCreateComparativeExperimentApiV1DatasetsComparativePostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateComparativeExperimentApiV1DatasetsComparativePostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ComparativeExperimentBase) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Comparative Experiment<br/>
        /// Create a comparative experiment.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="experimentIds"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="referenceDatasetId"></param>
        /// <param name="extra"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ComparativeExperimentBase> CreateComparativeExperimentApiV1DatasetsComparativePostAsync(
            global::System.Collections.Generic.IList<string> experimentIds,
            string referenceDatasetId,
            string? id = default,
            global::System.AnyOf<string?, object>? name = default,
            global::System.AnyOf<string?, object>? description = default,
            global::System.DateTime createdAt = default,
            global::System.DateTime modifiedAt = default,
            global::System.AnyOf<global::LangSmith.ComparativeExperimentCreateExtra, object>? extra = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.ComparativeExperimentCreate
            {
                Id = id,
                ExperimentIds = experimentIds,
                Name = name,
                Description = description,
                CreatedAt = createdAt,
                ModifiedAt = modifiedAt,
                ReferenceDatasetId = referenceDatasetId,
                Extra = extra,
            };

            return await CreateComparativeExperimentApiV1DatasetsComparativePostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}