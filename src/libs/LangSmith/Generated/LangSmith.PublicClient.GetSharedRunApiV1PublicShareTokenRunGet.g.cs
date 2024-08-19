
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareGetSharedRunApiV1PublicShareTokenRunGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string shareToken,
            ref bool excludeS3StoredAttributes);
        partial void PrepareGetSharedRunApiV1PublicShareTokenRunGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string shareToken,
            bool excludeS3StoredAttributes);
        partial void ProcessGetSharedRunApiV1PublicShareTokenRunGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSharedRunApiV1PublicShareTokenRunGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Shared Run<br/>
        /// Get the shared run.
        /// </summary>
        /// <param name="shareToken"></param>
        /// <param name="excludeS3StoredAttributes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.RunPublicSchema> GetSharedRunApiV1PublicShareTokenRunGetAsync(
            string shareToken,
            bool excludeS3StoredAttributes,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSharedRunApiV1PublicShareTokenRunGetArguments(
                httpClient: _httpClient,
                shareToken: ref shareToken,
                excludeS3StoredAttributes: ref excludeS3StoredAttributes);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/{shareToken}/run?exclude_s3_stored_attributes={excludeS3StoredAttributes}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSharedRunApiV1PublicShareTokenRunGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                shareToken: shareToken,
                excludeS3StoredAttributes: excludeS3StoredAttributes);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSharedRunApiV1PublicShareTokenRunGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSharedRunApiV1PublicShareTokenRunGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.RunPublicSchema) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}