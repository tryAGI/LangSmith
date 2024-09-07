
#nullable enable

namespace LangSmith
{
    public partial class PublicClient
    {
        partial void PrepareGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string ssoLoginSlug);
        partial void PrepareGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string ssoLoginSlug);
        partial void ProcessGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Sso Settings<br/>
        /// Get SSO provider settings from login slug.
        /// </summary>
        /// <param name="ssoLoginSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::LangSmith.SSOProviderSlim>> GetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetAsync(
            string ssoLoginSlug,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetArguments(
                httpClient: _httpClient,
                ssoLoginSlug: ref ssoLoginSlug);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/public/sso-settings/{ssoLoginSlug}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                ssoLoginSlug: ssoLoginSlug);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessGetSsoSettingsApiV1PublicSsoSettingsSsoLoginSlugGetResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.IListSSOProviderSlim) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}