
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            global::LangSmith.QueryFeedbackDelta request);
        partial void PrepareReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            global::LangSmith.QueryFeedbackDelta request);
        partial void ProcessReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SessionFeedbackDelta> ReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostAsync(
            string shareToken,
            global::LangSmith.QueryFeedbackDelta request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/datasets/runs/delta", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.QueryFeedbackDelta);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostRequest(
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
            ProcessReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.SessionFeedbackDelta) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Read Shared Delta<br/>
        /// Fetch the number of regressions/improvements for each example in a dataset, between sessions[0] and sessions[1].
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="baselineSessionId"></param>
        /// <param name="comparisonSessionIds"></param>
        /// <param name="feedbackKey"></param>
        /// <param name="filters"></param>
        /// <param name="offset">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SessionFeedbackDelta> ReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostAsync(
            string shareToken,
            string baselineSessionId,
            global::System.Collections.Generic.IList<string> comparisonSessionIds,
            string feedbackKey,
            global::System.AnyOf<global::LangSmith.QueryFeedbackDeltaFilters, object>? filters = default,
            int offset = 0,
            int limit = 100,
            global::System.AnyOf<string, object>? comparativeExperimentId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.QueryFeedbackDelta
            {
                BaselineSessionId = baselineSessionId,
                ComparisonSessionIds = comparisonSessionIds,
                FeedbackKey = feedbackKey,
                Filters = filters,
                Offset = offset,
                Limit = limit,
                ComparativeExperimentId = comparativeExperimentId,
            };

            return await ReadSharedDeltaApiV1PublicShareTokenDatasetsRunsDeltaPostAsync(
                shareToken: shareToken,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}