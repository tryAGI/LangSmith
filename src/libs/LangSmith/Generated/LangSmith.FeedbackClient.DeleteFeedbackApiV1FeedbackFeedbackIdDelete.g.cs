
#nullable enable

namespace LangSmith
{
    public partial class FeedbackClient
    {
        partial void PrepareDeleteFeedbackApiV1FeedbackFeedbackIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string feedbackId);
        partial void PrepareDeleteFeedbackApiV1FeedbackFeedbackIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string feedbackId);
        partial void ProcessDeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Feedback<br/>
        /// Delete a feedback.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponse> DeleteFeedbackApiV1FeedbackFeedbackIdDeleteAsync(
            string feedbackId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteFeedbackApiV1FeedbackFeedbackIdDeleteArguments(
                httpClient: _httpClient,
                feedbackId: ref feedbackId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback/{feedbackId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteFeedbackApiV1FeedbackFeedbackIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                feedbackId: feedbackId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteFeedbackApiV1FeedbackFeedbackIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}