
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareCreateFeedbackWithTokenPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid token,
            global::LangSmith.FeedbackCreateWithTokenExtendedSchema request);
        partial void PrepareCreateFeedbackWithTokenPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid token,
            global::LangSmith.FeedbackCreateWithTokenExtendedSchema request);
        partial void ProcessCreateFeedbackWithTokenPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateFeedbackWithTokenPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::LangSmith.FeedbackCreateWithTokenExtendedSchema request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareCreateFeedbackWithTokenPostArguments(
                httpClient: _httpClient,
                token: ref token,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback/tokens/{token}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, request.GetType(), JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareCreateFeedbackWithTokenPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                token: token,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessCreateFeedbackWithTokenPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessCreateFeedbackWithTokenPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::LangSmith.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse), JsonSerializerContext) as global::LangSmith.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Create Feedback With Token Post<br/>
        /// Create a new feedback with a token.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="metadata"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.CreateFeedbackWithTokenPostApiV1FeedbackTokensTokenPostResponse> CreateFeedbackWithTokenPostAsync(
            global::System.Guid token,
            global::LangSmith.AnyOf<double?, int?, bool?, object>? score = default,
            global::LangSmith.AnyOf<double?, int?, bool?, string, object>? value = default,
            global::LangSmith.AnyOf<string, object>? comment = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackCreateWithTokenExtendedSchemaCorrection, string, object>? correction = default,
            global::LangSmith.AnyOf<global::LangSmith.FeedbackCreateWithTokenExtendedSchemaMetadata, object>? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.FeedbackCreateWithTokenExtendedSchema
            {
                Score = score,
                Value = value,
                Comment = comment,
                Correction = correction,
                Metadata = metadata,
            };

            return await CreateFeedbackWithTokenPostAsync(
                token: token,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}