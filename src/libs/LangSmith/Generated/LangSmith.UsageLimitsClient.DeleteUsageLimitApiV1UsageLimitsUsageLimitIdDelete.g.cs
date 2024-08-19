
#nullable enable

namespace LangSmith
{
    public partial class UsageLimitsClient
    {
        partial void PrepareDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string usageLimitId);
        partial void PrepareDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string usageLimitId);
        partial void ProcessDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Usage Limit<br/>
        /// Delete a specific usage limit.
        /// </summary>
        /// <param name="usageLimitId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponse> DeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteAsync(
            string usageLimitId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteArguments(
                httpClient: _httpClient,
                usageLimitId: ref usageLimitId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/usage-limits/{usageLimitId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                usageLimitId: usageLimitId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteUsageLimitApiV1UsageLimitsUsageLimitIdDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}