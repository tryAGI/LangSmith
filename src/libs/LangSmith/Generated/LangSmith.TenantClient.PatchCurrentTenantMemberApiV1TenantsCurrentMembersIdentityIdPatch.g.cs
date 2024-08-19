
#nullable enable

namespace LangSmith
{
    public partial class TenantClient
    {
        partial void PreparePatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId,
            global::LangSmith.IdentityPatch request);
        partial void PreparePatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId,
            global::LangSmith.IdentityPatch request);
        partial void ProcessPatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Current Tenant Member<br/>
        /// Deprecated: replaced by /workspaces/current/members/{identity_id}
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponse> PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchAsync(
            string identityId,
            global::LangSmith.IdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchArguments(
                httpClient: _httpClient,
                identityId: ref identityId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tenants/current/members/{identityId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.IdentityPatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                identityId: identityId,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessPatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Current Tenant Member<br/>
        /// Deprecated: replaced by /workspaces/current/members/{identity_id}
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchResponse> PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchAsync(
            string identityId,
            string roleId,
            global::System.AnyOf<bool?, object>? readOnly = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.IdentityPatch
            {
                ReadOnly = readOnly,
                RoleId = roleId,
            };

            return await PatchCurrentTenantMemberApiV1TenantsCurrentMembersIdentityIdPatchAsync(
                identityId: identityId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}