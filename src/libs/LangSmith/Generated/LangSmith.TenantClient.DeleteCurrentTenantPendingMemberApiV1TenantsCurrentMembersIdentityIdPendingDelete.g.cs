
#nullable enable

namespace LangSmith
{
    public partial class TenantClient
    {
        partial void PrepareDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId);
        partial void PrepareDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId);
        partial void ProcessDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Delete Current Tenant Pending Member<br/>
        /// Deprecated: replaced by /workspaces/current/members/{identity_id}/pending
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.DeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponse> DeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteAsync(
            string identityId,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteArguments(
                httpClient: _httpClient,
                identityId: ref identityId);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Delete,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/tenants/current/members/{identityId}/pending", global::System.UriKind.RelativeOrAbsolute));

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                identityId: identityId);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessDeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.DeleteCurrentTenantPendingMemberApiV1TenantsCurrentMembersIdentityIdPendingDeleteResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}