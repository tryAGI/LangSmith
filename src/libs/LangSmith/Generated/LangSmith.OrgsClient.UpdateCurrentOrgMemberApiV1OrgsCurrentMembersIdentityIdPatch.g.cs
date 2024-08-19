
#nullable enable

namespace LangSmith
{
    public partial class OrgsClient
    {
        partial void PrepareUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void PrepareUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId,
            global::LangSmith.OrgIdentityPatch request);
        partial void ProcessUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchAsync(
            string identityId,
            global::LangSmith.OrgIdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PrepareUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchArguments(
                httpClient: _httpClient,
                identityId: ref identityId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/orgs/current/members/{identityId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.OrgIdentityPatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchRequest(
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
            ProcessUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessUpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Update Current Org Member<br/>
        /// This is used for updating a user's role (all auth modes) or full_name/password (basic auth)
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="password"></param>
        /// <param name="fullName"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchResponse> UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchAsync(
            string identityId,
            global::System.AnyOf<string?, object>? password = default,
            global::System.AnyOf<string?, object>? fullName = default,
            global::System.AnyOf<string, object>? roleId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = new global::LangSmith.OrgIdentityPatch
            {
                Password = password,
                FullName = fullName,
                RoleId = roleId,
            };

            return await UpdateCurrentOrgMemberApiV1OrgsCurrentMembersIdentityIdPatchAsync(
                identityId: identityId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}