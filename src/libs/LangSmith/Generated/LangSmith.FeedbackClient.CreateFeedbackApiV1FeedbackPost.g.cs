
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackApiV1FeedbackPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.FeedbackCreateSchema request);
        partial void PrepareCreateFeedbackApiV1FeedbackPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.FeedbackCreateSchema request);
        partial void ProcessCreateFeedbackApiV1FeedbackPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackApiV1FeedbackPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackApiV1FeedbackPostAsync(
            global::LangSmith.FeedbackCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFeedbackApiV1FeedbackPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/feedback", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.FeedbackCreateSchema);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFeedbackApiV1FeedbackPostRequest(
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
            ProcessCreateFeedbackApiV1FeedbackPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFeedbackApiV1FeedbackPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.FeedbackSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.FeedbackSchema> CreateFeedbackApiV1FeedbackPostAsync(
            string key,
            global::System.DateTime createdAt = default,
            global::System.DateTime modifiedAt = default,
            global::System.AnyOf<double?, int?, bool?, object>? score = default,
            global::System.AnyOf<double?, int?, bool?, string, global::LangSmith.FeedbackCreateSchemaValue, object>? value = default,
            global::System.AnyOf<string, object>? comment = default,
            global::System.AnyOf<global::LangSmith.FeedbackCreateSchemaCorrection, string, object>? correction = default,
            global::System.AnyOf<string, object>? feedbackGroupId = default,
            global::System.AnyOf<string, object>? comparativeExperimentId = default,
            global::System.AnyOf<string, object>? runId = default,
            global::System.AnyOf<string, object>? sessionId = default,
            string? id = default,
            global::System.AnyOf<global::LangSmith.AppFeedbackSource, global::LangSmith.APIFeedbackSource, global::LangSmith.ModelFeedbackSource, global::LangSmith.AutoEvalFeedbackSource, object>? feedbackSource = default,
            global::System.AnyOf<global::LangSmith.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.FeedbackCreateSchema
            {
                CreatedAt = createdAt,
                ModifiedAt = modifiedAt,
                Key = key,
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                FeedbackGroupId = feedbackGroupId,
                ComparativeExperimentId = comparativeExperimentId,
                RunId = runId,
                SessionId = sessionId,
                Id = id,
                FeedbackSource = feedbackSource,
                FeedbackConfig = feedbackConfig,
            };

            return await CreateFeedbackApiV1FeedbackPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}