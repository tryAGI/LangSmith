
#nullable enable

namespace LangSmith
{
    public partial class ServiceAccountsClient
    {
        partial void PrepareDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string serviceAccountId);
        partial void PrepareDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string serviceAccountId);
        partial void ProcessDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Service Account<br/>
        /// Delete a service account
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.ServiceAccountDeleteResponse> DeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteAsync(
            string serviceAccountId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteArguments(
                httpClient: _httpClient,
                serviceAccountId: ref serviceAccountId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/service-accounts/{serviceAccountId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                serviceAccountId: serviceAccountId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteServiceAccountApiV1ServiceAccountsServiceAccountIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.ServiceAccountDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}