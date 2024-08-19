
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::LangSmith.QueryExampleSchemaWithRuns request);
        partial void PrepareReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::LangSmith.QueryExampleSchemaWithRuns request);
        partial void ProcessReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Dataset Examples With Runs<br/>
        /// Get examples with associated runs from sessions in a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostAsync(
            string shareToken,
            global::LangSmith.QueryExampleSchemaWithRuns request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/examples/runs", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.QueryExampleSchemaWithRuns);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostRequest(
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
            ProcessReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.NullableAnyOfIListPublicExampleWithRunsIListExampleWithRunsCH) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Shared Dataset Examples With Runs<br/>
        /// Get examples with associated runs from sessions in a dataset that has been shared.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="sessionIds"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 20
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.AnyOf<global::System.Collections.Generic.IList<global::LangSmith.PublicExampleWithRuns>, global::System.Collections.Generic.IList<global::LangSmith.ExampleWithRunsCH>>> ReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostAsync(
            string shareToken,
            global::System.Collections.Generic.IList<string> sessionIds,
            global::System.AnyOf<string, object>? comparativeExperimentId = default,
            global::System.AnyOf<global::LangSmith.QueryExampleSchemaWithRunsFilters, object>? filters = default,
            int offset = 0,
            int limit = 20,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.QueryExampleSchemaWithRuns
            {
                SessionIds = sessionIds,
                ComparativeExperimentId = comparativeExperimentId,
                Filters = filters,
                Offset = offset,
                Limit = limit,
            };

            return await ReadSharedDatasetExamplesWithRunsApiV1PublicShareTokenExamplesRunsPostAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}