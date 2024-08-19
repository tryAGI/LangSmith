
#nullable enable

namespace LangSmith
{
    public partial class TenantClient
    {
        partial void PrepareAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::LangSmith.PendingIdentityCreate request);
        partial void PrepareAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::LangSmith.PendingIdentityCreate request);
        partial void ProcessAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Add Member To Current Tenant<br/>
        /// Deprecated: replaced by /workspaces/current/members
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentTenantApiV1TenantsCurrentMembersPostAsync(
            global::LangSmith.PendingIdentityCreate request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostArguments(
                httpClient: _httpClient,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + "/api/v1/tenants/current/members", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.PendingIdentityCreate);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                request: request);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessAddMemberToCurrentTenantApiV1TenantsCurrentMembersPostResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.PendingIdentity) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Add Member To Current Tenant<br/>
        /// Deprecated: replaced by /workspaces/current/members
        /// </summary>
        /// <param name="email"></param>
        /// <param name="readOnly">
        /// Default Value: false
        /// </param>
        /// <param name="roleId"></param>
        /// <param name="workspaceIds"></param>
        /// <param name="workspaceRoleId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        public async global::System.Threading.Tasks.Task<global::LangSmith.PendingIdentity> AddMemberToCurrentTenantApiV1TenantsCurrentMembersPostAsync(
            string email,
            bool readOnly = false,
            global::System.AnyOf<string, object>? roleId = default,
            global::System.AnyOf<global::System.Collections.Generic.IList<string>, object>? workspaceIds = default,
            global::System.AnyOf<string, object>? workspaceRoleId = default,
            global::System.AnyOf<string?, object>? password = default,
            global::System.AnyOf<string?, object>? fullName = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.PendingIdentityCreate
            {
                Email = email,
                ReadOnly = readOnly,
                RoleId = roleId,
                WorkspaceIds = workspaceIds,
                WorkspaceRoleId = workspaceRoleId,
                Password = password,
                FullName = fullName,
            };

            return await AddMemberToCurrentTenantApiV1TenantsCurrentMembersPostAsync(
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}