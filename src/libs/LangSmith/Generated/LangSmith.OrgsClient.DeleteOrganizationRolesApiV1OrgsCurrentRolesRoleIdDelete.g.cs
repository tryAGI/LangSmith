
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string roleId);
        partial void PrepareDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string roleId);
        partial void ProcessDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Role> DeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteAsync(
            string roleId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteArguments(
                httpClient: _httpClient,
                roleId: ref roleId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/roles/{roleId}", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                roleId: roleId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteOrganizationRolesApiV1OrgsCurrentRolesRoleIdDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.Role) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}