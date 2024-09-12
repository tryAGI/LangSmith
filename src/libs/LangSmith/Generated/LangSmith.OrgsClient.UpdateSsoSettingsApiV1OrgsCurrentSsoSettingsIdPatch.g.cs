
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string id,
            global::LangSmith.SSOSettingsUpdate request);
        partial void PrepareUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string id,
            global::LangSmith.SSOSettingsUpdate request);
        partial void ProcessUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> UpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchAsync(
            string id,
            global::LangSmith.SSOSettingsUpdate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchArguments(
                httpClient: _httpClient,
                id: ref id,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/sso-settings/{id}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.SSOSettingsUpdate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                id: id,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.SSOProvider) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Sso Settings<br/>
        /// Update SSO provider settings defaults for the current organization.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="defaultWorkspaceRoleId"></param>
        /// <param name="defaultWorkspaceIds"></param>
        /// <param name="metadataUrl"></param>
        /// <param name="metadataXml"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.SSOProvider> UpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchAsync(
            string id,
            global::System.AnyOf<string, object>? defaultWorkspaceRoleId = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? defaultWorkspaceIds = default,
            global::System.AnyOf<string, object>? metadataUrl = default,
            global::System.AnyOf<string, object>? metadataXml = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.SSOSettingsUpdate
            {
                DefaultWorkspaceRoleId = defaultWorkspaceRoleId,
                DefaultWorkspaceIds = defaultWorkspaceIds,
                MetadataUrl = metadataUrl,
                MetadataXml = metadataXml,
            };

            return await UpdateSsoSettingsApiV1OrgsCurrentSsoSettingsIdPatchAsync(
                id: id,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}