
#nullable enable

namespace LangSmith
{
    public partial class FeedbackConfigsClient
    {
        partial void PrepareListFeedbackConfigsEndpointApiV1FeedbackConfigsGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key);
        partial void PrepareListFeedbackConfigsEndpointApiV1FeedbackConfigsGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key);
        partial void ProcessListFeedbackConfigsEndpointApiV1FeedbackConfigsGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessListFeedbackConfigsEndpointApiV1FeedbackConfigsGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// List Feedback Configs Endpoint
        /// </summary>
        /// <param name="key"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.FeedbackConfigSchema>> ListFeedbackConfigsEndpointApiV1FeedbackConfigsGetAsync(
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? key = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareListFeedbackConfigsEndpointApiV1FeedbackConfigsGetArguments(
                httpClient: _httpClient,
                key: ref key);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/feedback-configs?key={key}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareListFeedbackConfigsEndpointApiV1FeedbackConfigsGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                key: key);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessListFeedbackConfigsEndpointApiV1FeedbackConfigsGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessListFeedbackConfigsEndpointApiV1FeedbackConfigsGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListFeedbackConfigSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}