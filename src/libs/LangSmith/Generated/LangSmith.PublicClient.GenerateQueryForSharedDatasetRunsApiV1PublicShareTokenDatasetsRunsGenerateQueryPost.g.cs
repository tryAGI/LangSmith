
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::LangSmith.RequestBodyForRunsGenerateQuery request);
        partial void PrepareGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::LangSmith.RequestBodyForRunsGenerateQuery request);
        partial void ProcessGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Query For Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostAsync(
            string shareToken,
            global::LangSmith.RequestBodyForRunsGenerateQuery request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/generate-query", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.RequestBodyForRunsGenerateQuery);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ResponseBodyForRunsGenerateQuery) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Generate Query For Shared Dataset Runs<br/>
        /// Get runs in projects run over a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="query"></param>
        /// <param name="feedbackKeys"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ResponseBodyForRunsGenerateQuery> GenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostAsync(
            string shareToken,
            string query,
            global::System.Collections.Generic.IList<global::LangSmith.RunsGenerateQueryFeedbackKeys>? feedbackKeys = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.RequestBodyForRunsGenerateQuery
            {
                Query = query,
                FeedbackKeys = feedbackKeys,
            };

            return await GenerateQueryForSharedDatasetRunsApiV1PublicShareTokenDatasetsRunsGenerateQueryPostAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}