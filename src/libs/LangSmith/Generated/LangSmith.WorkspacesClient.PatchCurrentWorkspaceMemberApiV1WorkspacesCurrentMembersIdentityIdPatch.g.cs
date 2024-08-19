
#nullable enable

namespace LangSmith
{
    public partial class WorkspacesClient
    {
        partial void PreparePatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string identityId,
            global::LangSmith.IdentityPatch request);
        partial void PreparePatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string identityId,
            global::LangSmith.IdentityPatch request);
        partial void ProcessPatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchAsync(
            string identityId,
            global::LangSmith.IdentityPatch request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: _httpClient);
            PreparePatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchArguments(
                httpClient: _httpClient,
                identityId: ref identityId,
                request: request);

            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
                requestUri: new global::System.Uri(_httpClient.BaseAddress?.AbsoluteUri.TrimEnd('/') + $"/api/v1/workspaces/current/members/{identityId}", global::System.UriKind.RelativeOrAbsolute));
            var __httpRequestContentBody = global::System.Text.Json.JsonSerializer.Serialize(request, global::LangSmith.SourceGenerationContext.Default.IdentityPatch);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PreparePatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchRequest(
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
            ProcessPatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessPatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponseContent(
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
                global::System.Text.Json.JsonSerializer.Deserialize(__content, global::LangSmith.SourceGenerationContext.Default.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Patch Current Workspace Member
        /// </summary>
        /// <param name="identityId"></param>
        /// <param name="readOnly"></param>
        /// <param name="roleId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::LangSmith.PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchResponse> PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchAsync(
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

            return await PatchCurrentWorkspaceMemberApiV1WorkspacesCurrentMembersIdentityIdPatchAsync(
                identityId: identityId,
                request: request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}