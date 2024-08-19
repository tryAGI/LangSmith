
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string roleId,
            global::LangSmith.UpdateRoleRequest request);
        partial void PrepareUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string roleId,
            global::LangSmith.UpdateRoleRequest request);
        partial void ProcessUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Role> UpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchAsync(
            string roleId,
            global::LangSmith.UpdateRoleRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchArguments(
                httpClient: _httpClient,
                roleId: ref roleId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/roles/{roleId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.UpdateRoleRequest);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                roleId: roleId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchResponseContent(
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

        /// <summary>
        /// Update Organization Roles
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="displayName"></param>
        /// <param name="description"></param>
        /// <param name="permissions"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.Role> UpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchAsync(
            string roleId,
            string displayName,
            string description,
            global::System.Collections.Generic.IList<string> permissions,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.UpdateRoleRequest
            {
                DisplayName = displayName,
                Description = description,
                Permissions = permissions,
            };

            return await UpdateOrganizationRolesApiV1OrgsCurrentRolesRoleIdPatchAsync(
                roleId: roleId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}